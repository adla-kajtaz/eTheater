using AutoMapper;
using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using eTheater.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class ShowScheduleService : BaseCRUDService<Model.ShowSchedule, Database.ShowSchedule, ShowScheduleSearchObject, ShowScheduleUpsertRequest, ShowScheduleUpsertRequest>, IShowScheduleService
    {
        public ShowScheduleService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.ShowSchedule> AddInclude(IQueryable<eTheater.Services.Database.ShowSchedule> query, ShowScheduleSearchObject search = null)
        {
            query = query.Include(x => x.Show).Include(x => x.Hall);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eTheater.Services.Database.ShowSchedule> AddFilter(IQueryable<eTheater.Services.Database.ShowSchedule> query, ShowScheduleSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ShowId != null)
                filteredQuery = filteredQuery.Where(x => x.ShowId == search.ShowId);
            if (search.HallId != null)
                filteredQuery = filteredQuery.Where(x => x.HallId == search.HallId);
            if (search.ShowDate.HasValue)
                filteredQuery = filteredQuery.Where(x => x.ShowDate.Date.Equals(search.ShowDate.Value.Date));
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.ShowSchedule Delete(int id)
        {
           var entity = _context.ShowSchedules.Find(id);
           var tickets = _context.Tickets.Where(e => e.ShowScheduleId == id).ToList();

           if (tickets != null && tickets.Any())
           {
                return null;
           }
           else if(entity == null)
           {
                return null;
           }
           else
           {
                entity.IsDeleted = true;
           }

            _context.SaveChanges();
            return _mapper.Map<Model.ShowSchedule>(entity);
        }

        public List<string> GetTimeSlotsForDate(int hallId, string date)
        {
            var showSchedules = _context.ShowSchedules.Where(e => e.ShowDate.ToString() == date && e.HallId == hallId);
            List<string> slots = Helper.getTimeSlots();
            List<string> responseSlots = new List<string> { };
            foreach (string slot in slots)
            {

                if (!showSchedules.Any(e => e.ShowTime == slot))
                    responseSlots.Add(slot);
            };
            return responseSlots;
        }

        static object isLocked = new object();
        static MLContext mlContext = null;
        static ITransformer model = null;

        public List<Model.ShowSchedule> ShowScheduleRecommenderSystem(int userId)
        {
            var purchases = _context.Purchases
                .Include(p => p.ShowSchedule)
                .ThenInclude(p => p.Hall)
                .Include(p => p.ShowSchedule.Show)
                .Where(p => p.UserId == userId && p.IsPaid == true)
                .ToList();

            if (purchases.Count < 3)
            {
                throw new RecommendationException("You must have at least 3 purchases before we recommend something!");
            }

            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();

                    var data = new List<ShowGenreEntry>();

                    var genreCounts = purchases
                        .GroupBy(p => p.ShowSchedule.Show.ShowGenre)
                        .Select(group => new
                        {
                            ShowGenre = (uint)group.Key,
                            Count = group.Count()
                        }).ToList();

                    foreach (var purchase in purchases)
                    {
                        var genreCount = genreCounts.FirstOrDefault(g => g.ShowGenre == (uint)purchase.ShowSchedule.Show.ShowGenre);
                        data.Add(new ShowGenreEntry
                        {
                            UserId = (uint)purchase.UserId.GetValueOrDefault(),
                            ShowGenre = (uint)purchase.ShowSchedule.Show.ShowGenre,
                            ShowGenreCount = genreCount.Count
                        });
                    }

                    if (!data.Any())
                    {
                        throw new Exception("The training data is empty!");
                    }

                    var trainData = mlContext.Data.LoadFromEnumerable(data);
                    var trainTestSplit = mlContext.Data.TrainTestSplit(trainData, testFraction: 0.2);

                    var options = new MatrixFactorizationTrainer.Options
                    {
                        MatrixColumnIndexColumnName = nameof(ShowGenreEntry.UserId),
                        MatrixRowIndexColumnName = nameof(ShowGenreEntry.ShowGenre),
                        LabelColumnName = "ShowGenreCount",
                        LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                        Alpha = 0.01,
                        Lambda = 0.025
                    };

                    var trainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    model = trainer.Fit(trainTestSplit.TrainSet);
                    if (model == null)
                    {
                        throw new Exception("Model training failed, resulting model is null.");
                    }
                }
            }

            var predictionResult = new List<Tuple<Database.ShowSchedule, float>>();
            var showSchedules = _context.ShowSchedules.Include(s => s.Show).Include(s => s.Hall).ToList();

            foreach (var showSchedule in showSchedules)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ShowGenreEntry, ShowGenrePrediction>(model);
                var prediction = predictionEngine.Predict(new ShowGenreEntry()
                {
                    UserId = (uint)userId,
                    ShowGenre = (uint)showSchedule.Show.ShowGenre
                });

                predictionResult.Add(new Tuple<Database.ShowSchedule, float>(showSchedule, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(x => x.Item1)
                .ToList()
                .Take(3);

            return _mapper.Map<List<Model.ShowSchedule>>(finalResult);
        }

        public class ShowGenreEntry
        {
            [KeyType(count: 10)]
            public uint UserId { get; set; }

            [KeyType(count: 10)]
            public uint ShowGenre { get; set; }

            public float ShowGenreCount { get; set; }
        }

        public class ShowGenrePrediction
        {
            [KeyType(count: 10)]
            public uint ShowGenre { get; set; }
            public float Score { get; set; }
            public float Label { get; set; }
        }
    }
}
