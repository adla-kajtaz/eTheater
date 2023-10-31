using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    public class UserController : BaseCRUDController<Model.User, UserSearchObject, UserUpdateRequest, UserUpdateRequest>
    {
        public IUserService _service { get; set; }
        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public override User Insert([FromBody] UserUpdateRequest insert)
        {
            throw new UserException("Not allowed", "Manually inserting users in the system is not allowed");
        }
    }
}
