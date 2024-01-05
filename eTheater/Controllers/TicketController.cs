using eTheater.Model;
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
        [HttpGet("GetByShowScheduleId/{id}")]
        public IEnumerable<Model.Ticket> GetByShowScheduleId(int id)
        {
            return _service.GetByShowScheduleId(id);
        }

        [Authorize]
        [HttpPut("{id}")]
        public override Ticket Update(int id, [FromBody] TicketUpsertRequest insert)
        {
            throw new eTheaterException("Not allowed", "Manually editing tickets in the system is not allowed");
        }
    }
}
