using AutoMapper;
using eTheater.Model;
using eTheater.Model.Enums;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using eTheater.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class ShowService : BaseCRUDService<Model.Show, Database.Show, ShowSearchObject, ShowUpsertRequest, ShowUpsertRequest>, IShowService
    {
        public ShowService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.Show> AddFilter(IQueryable<eTheater.Services.Database.Show> query, ShowSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
                filteredQuery = filteredQuery.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            if (search?.ShowGenre != null)
                filteredQuery = filteredQuery.Where(x => x.ShowGenre == search.ShowGenre);
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.Show Delete(int id)
        {
            var entity = _context.Shows.Find(id);
            var showSchedules = _context.ShowSchedules.Where(e => e.ShowId == id).ToList();
            var showActors = _context.ShowActors.Where(e => e.ShowId == id).ToList();

            if (showSchedules != null && showSchedules.Any())
            {
                return null;
            }
            else if (showActors != null && showActors.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Show>(entity);
        }

        public Model.RevenuesPerShow RevenuesPerShowReport(int showId)
        {
            var showSchedules = _context.ShowSchedules.Where(e => e.ShowId == showId).ToList();
            int numberOfTickets = 0, price = 0, revenue = 0;
            foreach (var showSchedule in showSchedules)
            {
                var tickets = _context.Tickets.Where(e => e.ShowScheduleId == showSchedule.ShowScheduleId && e.IsActive == false).ToList();

                var counter = tickets.Count;
                numberOfTickets += counter;
                price = showSchedule.TicketPrice ?? 0;
                revenue += (counter * price);
            }

            var report = new RevenuesPerShow()
            {
                NumberOfTickets = numberOfTickets,
                NumberOfShowSchedules = showSchedules.Count,
                TotalRevenues = revenue
            };

            return report;
        }
    }
}
