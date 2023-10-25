using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class ShowController : BaseCRUDController<Model.Show, ShowSearchObject, ShowUpsertRequest, ShowUpsertRequest>
    {
        public IShowService _service { get; set; }
        public ShowController(IShowService service) : base(service)
        {
            _service = service;
        }
    }
}
