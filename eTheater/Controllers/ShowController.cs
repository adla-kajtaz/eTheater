using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    public class ShowController : BaseCRUDController<Model.Show, ShowSearchObject, ShowUpsertRequest, ShowUpsertRequest>
    {
        public IShowService _service { get; set; }
        public ShowController(IShowService service) : base(service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet("revenuesPerShowReport/{id}")]
        public Model.RevenuesPerShow RevenuesPerShowReport(int id)
        {
            return _service.RevenuesPerShowReport(id);
        }
    }
}
