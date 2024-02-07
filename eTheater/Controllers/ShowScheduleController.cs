using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eTheater.Controllers
{
    public class ShowScheduleController : BaseCRUDController<Model.ShowSchedule, ShowScheduleSearchObject, ShowScheduleInsertRequest, ShowScheduleUpdateRequest>
    {
        public IShowScheduleService _service { get; set; }
        public ShowScheduleController(IShowScheduleService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("getTimeSlotsForDate")]
        public List<string> GetTimeSlotsForDate(int hallId, DateTime date)
        {
            return _service.GetTimeSlotsForDate(hallId, date);
        }

        [HttpGet("getTimeSlotsForDate2")]
        public List<string> GetTimeSlotsForDate2(int hallId, DateTime date, int showScheduleId)
        {
            return _service.GetTimeSlotsForDate2(hallId, date, showScheduleId);
        }

        [Authorize]
        [HttpGet("recommend")]
        public List<Model.ShowSchedule> Recommend()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return _service.ShowScheduleRecommenderSystem(userId);
        }

        [Authorize]
        [HttpGet("deleteTickets/{id}")]
        public void DeleteTickets(int id)
        {
           _service.DeleteTicketsByShowScheduleId(id);
        }
    }
}
