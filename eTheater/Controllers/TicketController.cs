using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPatch("{id}")]
        public Model.Ticket ChangeStatus(int id, int PurchaseId)
        {
            return _service.ChangeStatus(id, PurchaseId);
        }

        [Authorize]
        [HttpGet("GetByShowScheduleId/{id}")]
        public IEnumerable<Model.Ticket> GetByShowScheduleId(int id)
        {
            return _service.GetByShowScheduleId(id);
        }
    }
}
