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
    public class TicketService : BaseCRUDService<Model.Ticket, Database.Ticket, TicketSearchObject, TicketUpsertRequest, TicketUpsertRequest>, ITicketService
    {
        public TicketService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.Ticket> AddInclude(IQueryable<eTheater.Services.Database.Ticket> query, TicketSearchObject search = null)
        {
            query = query.Include(x => x.ShowSchedule).Include(x => x.ShowSchedule.Hall).Include(x => x.ShowSchedule.Show).Include(x => x.Purchase);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eTheater.Services.Database.Ticket> AddFilter(IQueryable<eTheater.Services.Database.Ticket> query, TicketSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ShowScheduleId != null)
                filteredQuery = filteredQuery.Where(x => x.ShowScheduleId == search.ShowScheduleId);
            if (search.IsActive != null)
                filteredQuery = filteredQuery.Where(x => x.IsActive == search.IsActive);
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);

            return filteredQuery;
        }

        public override Model.Ticket Delete(int id)
        {
            var entity = _context.Tickets.Find(id);

            if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Ticket>(entity);
        }

        public Model.Ticket ChangeStatus(int id, int PurchaseId)
        {
            var entity = _context.Tickets.Find(id);
            var kupovina = _context.Purchases.Find(PurchaseId);
            if (entity == null)
                return null;
            else
            {
                entity.IsActive = false;
                entity.PurchaseId = PurchaseId;
                if (kupovina != null)
                    kupovina.IsPaid = true;
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Ticket>(entity);
        }

        public IEnumerable<Model.Ticket> GetByShowScheduleId(int id)
        {
            var entity = _context.Tickets.Include(x => x.ShowSchedule).Include(x => x.ShowSchedule.Show).Include(x => x.ShowSchedule.Hall).Include(x => x.Purchase).Where(x => x.ShowScheduleId == id).AsQueryable();
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Ticket>>(list);
        }
    }
}
