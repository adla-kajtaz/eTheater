using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class ShowActorController : BaseCRUDController<Model.ShowActor, ShowActorSearchObject, ShowActorUpsertRequest, ShowActorUpsertRequest>
    {
        public IShowActorService _service { get; set; }

        public ShowActorController(IShowActorService service) : base(service)
        {
            _service = service;
        }
    }
}
