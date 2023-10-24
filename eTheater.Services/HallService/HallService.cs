using AutoMapper;
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
    public class HallService : BaseCRUDService <Model.Hall, Database.Hall, HallSearchObject, HallUpsertRequest, HallUpsertRequest>, IHallService
    {
        public HallService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
