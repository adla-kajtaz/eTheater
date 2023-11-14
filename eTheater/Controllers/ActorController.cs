using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class ActorController : BaseCRUDController<Model.Actor, ActorSearchObject, ActorUpsertRequest, ActorUpsertRequest>
    {
        public IActorService _service { get; set; }

        public ActorController(IActorService service) : base(service)
        {
            _service = service;
        }
    }
}
