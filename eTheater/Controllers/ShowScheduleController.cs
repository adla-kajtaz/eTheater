using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class ShowScheduleController : BaseCRUDController<Model.ShowSchedule, ShowScheduleSearchObject, ShowScheduleUpsertRequest, ShowScheduleUpsertRequest>
    {
        public IShowScheduleService _service { get; set; }
        public ShowScheduleController(IShowScheduleService service) : base(service)
        {
            _service = service;
        }
    }
}
