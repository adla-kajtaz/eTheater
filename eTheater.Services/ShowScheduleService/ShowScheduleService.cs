using AutoMapper;
using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using eTheater.Services.Database;
using Microsoft.EntityFrameworkCore;
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
    }
}
