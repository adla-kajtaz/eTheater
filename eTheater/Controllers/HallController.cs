using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class HallController : BaseCRUDController<Model.Hall, HallSearchObject, HallUpsertRequest, HallUpsertRequest>
    {
        public IHallService _service { get; set; }
        public HallController(IHallService service) : base(service)
        {
            _service = service;
        }
    }
}
