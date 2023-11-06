using AutoMapper;
using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        public IMapper _mapper { get; set; }

        public AuthController(IAuthService service, IMapper mapper) : base()
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpPost("login")]
        public async Task<AuthToken> Login([FromBody] LoginRequest body)
        {
            var token = await _service.Login(body);
            return token;
        }

        [HttpPost("login/admin")]
        public async Task<AuthToken> LoginAdmin([FromBody] LoginRequest body)
        {
            var admin = await _service.LoginAdmin(body);
            return admin;
        }

        [HttpPost("register")]
        public async Task<AuthToken> Register([FromBody] RegisterRequest body)
        {

            var user = await _service.Register(body);
            return user;
        }
    }
}
