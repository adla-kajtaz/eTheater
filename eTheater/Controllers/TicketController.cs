using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    public class TicketController : BaseCRUDController<Model.Ticket, TicketSearchObject, TicketUpsertRequest, TicketUpsertRequest>
    {
        public ITicketService _service { get; set; }
        public TicketController(ITicketService service) : base(service)
        {
            _service = service;
        }

        [HttpPatch("{id}")]
        public Model.Ticket ChangeStatus(int id, int PurchaseId)
        {
            return _service.ChangeStatus(id, PurchaseId);
        }

        [HttpGet("GetByShowScheduleId/{id}")]
        public IEnumerable<Model.Ticket> GetByShowScheduleId(int id)
        {
            return _service.GetByShowScheduleId(id);
        }
    }
}
