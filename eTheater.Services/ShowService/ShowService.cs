using AutoMapper;
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
            if (search?.ShowGenre != ShowGenre.All)
                filteredQuery = filteredQuery.Where(x => x.ShowGenre == search.ShowGenre);
            return filteredQuery;
        }
    }
}
