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
    public class ShowActorService : BaseCRUDService<Model.ShowActor, Database.ShowActor, ShowActorSearchObject, ShowActorUpsertRequest, ShowActorUpsertRequest>, IShowActorService
    {
        public ShowActorService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.ShowActor> AddInclude(IQueryable<eTheater.Services.Database.ShowActor> query, ShowActorSearchObject search = null)
        {
            query = query.Include(x => x.Show).Include(x => x.Actor);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eTheater.Services.Database.ShowActor> AddFilter(IQueryable<eTheater.Services.Database.ShowActor> query, ShowActorSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ShowId != null)
                filteredQuery = filteredQuery.Where(x => x.ShowId == search.ShowId);
            if (search.ActorId != null)
                filteredQuery = filteredQuery.Where(x => x.ActorId == search.ActorId);
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.ShowActor Delete(int id)
        {
            var entity = _context.ShowActors.Find(id);
            var showActors = _context.ShowActors.Where(e => e.ShowId == entity!.ShowId && e.IsDeleted == false).ToList();

            if (entity == null)
            {
                return null;
            }
            else if (showActors!.Count() == 1)
            {
                throw new eTheaterException("Warning", "You cannot delete an actor, the show must have at least one actor!");
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.ShowActor>(entity);
        }
    }
}
