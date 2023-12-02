using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eTheater.Controllers
{
    public class UserController : BaseCRUDController<Model.User, UserSearchObject, UserUpdateRequest, UserUpdateRequest>
    {
        public IUserService _service { get; set; }
        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("getMe")]
        public User GetMe()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return _service.GetMe(userId);
        }

        [Authorize]
        [HttpPost]
        public override User Insert([FromBody] UserUpdateRequest insert)
        {
            throw new eTheaterException("Not allowed", "Manually inserting users in the system is not allowed");
        }
    }
}
