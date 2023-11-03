using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    public class PurchaseController : BaseCRUDController<Model.Purchase, PurchaseSearchObject, PurchaseUpsertRequest, PurchaseUpsertRequest>
    {
        public IPurchaseService _service { get; set; }
        public PurchaseController(IPurchaseService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("GetByUserId/{id}")]
        public IEnumerable<Model.Purchase> GetByUserId(int id)
        {
            return _service.GetByUserId(id);
        }
    }
}
