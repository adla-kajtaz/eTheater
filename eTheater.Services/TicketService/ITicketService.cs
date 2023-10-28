using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public interface ITicketService : IBaseCRUDService<Model.Ticket, TicketSearchObject, TicketUpsertRequest, TicketUpsertRequest>
    {
        Model.Ticket ChangeStatus(int id, int PurchaseId);
        IEnumerable<Model.Ticket> GetByShowScheduleId(int id);
    }
}
