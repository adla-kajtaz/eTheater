using eTheater.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController <T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IBaseService<T, TSearch> _service { get; set; }
        public BaseController(IBaseService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual IEnumerable<T> GetAll([FromQuery] TSearch search = null)
        {
            return _service.GetAll(search);
        }

        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
