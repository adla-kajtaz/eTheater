using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;

namespace eTheater.Controllers
{
    public class NotificationController : BaseCRUDController<Model.Notification, NotificationSearchObject, NotificationUpsertRequest, NotificationUpsertRequest>
    {
        public INotificationService _service { get; set; }
        public NotificationController(INotificationService service) : base(service)
        {
            _service = service;
        }
    }
}
