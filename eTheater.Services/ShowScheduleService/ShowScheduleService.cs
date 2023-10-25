using AutoMapper;
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
            return filteredQuery;
        }
    }
}
