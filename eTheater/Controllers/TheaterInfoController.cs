using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class TheaterInfoController : BaseCRUDController<Model.TheaterInfo,BaseSearchObject, TheaterInfoUpsertRequest, TheaterInfoUpsertRequest>
    {
        public ITheaterInfoService _service { get; set; }
        public TheaterInfoController(ITheaterInfoService service) : base(service)
        {
            _service = service;
        }
    }
}
