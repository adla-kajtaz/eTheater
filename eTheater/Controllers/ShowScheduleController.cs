using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    public class ShowScheduleController : BaseCRUDController<Model.ShowSchedule, ShowScheduleSearchObject, ShowScheduleUpsertRequest, ShowScheduleUpsertRequest>
    {
        public IShowScheduleService _service { get; set; }
        public ShowScheduleController(IShowScheduleService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("GetTimeSlotsForDate")]
        public List<string> GetTimeSlotsForDate(int hallId, string date)
        {
            return _service.GetTimeSlotsForDate(hallId, date);
        }
    }
}
