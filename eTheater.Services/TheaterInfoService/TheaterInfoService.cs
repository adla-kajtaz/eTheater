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
    public class TheaterInfoService : BaseCRUDService<Model.TheaterInfo, Database.TheaterInfo, BaseSearchObject, TheaterInfoUpsertRequest, TheaterInfoUpsertRequest>, ITheaterInfoService
    {
        public TheaterInfoService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override Model.TheaterInfo Delete(int id)
        {
            var entity = _context.TheaterInfos.Find(id);

           if (entity == null)
           {
                return null;
           }
           else
           {
                entity.IsDeleted = true;
           }

            _context.SaveChanges();
            return _mapper.Map<Model.TheaterInfo>(entity);
        }
    }
}
