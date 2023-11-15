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
    public class ActorService : BaseCRUDService<Model.Actor, Database.Actor, ActorSearchObject, ActorUpsertRequest, ActorUpsertRequest>, IActorService
    {
        public ActorService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.Actor> AddFilter(IQueryable<eTheater.Services.Database.Actor> query, ActorSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
                filteredQuery = filteredQuery.Where(x => x.FirstName.ToLower().Contains(search.Name.ToLower()));
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.Actor Delete(int id)
        {
            var entity = _context.Actors.Find(id);
            var showActors = _context.ShowActors.Where(e => e.ActorId == id).ToList();

            if (showActors != null && showActors.Any())
            {
                return null;
            }
            else
            if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Actor>(entity);
        }
    }
}
