using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eTheater.Controllers
{
    public class PurchaseController : BaseCRUDController<Model.Purchase, PurchaseSearchObject, PurchaseUpsertRequest, PurchaseUpsertRequest>
    {
        public IPurchaseService _service { get; set; }

        public PurchaseController(IPurchaseService service) : base(service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet("GetByUser")]
        public IEnumerable<Model.Purchase> GetByUserId()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return _service.GetByUserId(userId);
        }

        public override Purchase Delete(int id)
        {
            throw new eTheaterException("Not allowed", "Deleting purchase is not allowed");
        }

        public override Purchase Update(int id, [FromBody] PurchaseUpsertRequest update)
        {
            throw new eTheaterException("Not allowed", "Updating purchase is not allowed");
        }

        [Authorize]
        [HttpPost]
        public override Model.Purchase Insert([FromBody] PurchaseUpsertRequest insert)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return _service.Insert(userId, insert);
        }

        [Authorize]
        [HttpPatch()]
        public Model.Purchase ChangeStatus([FromBody] TicketChangeStatus request)
        {
            return _service.ChangeTicketStatus(request);
        }
    }
}
