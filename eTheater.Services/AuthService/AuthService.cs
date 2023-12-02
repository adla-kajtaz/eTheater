using AutoMapper;
using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Services.Database;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class AuthService : IAuthService
    {
        public ETheaterContext _context { get; set; }
        public IMapper _mapper { get; set; }
        public ITokenService _tokenService { get; set; }
        private readonly UserManager<Database.User> _userManager;
        private readonly SignInManager<Database.User> _signInManager;

        public AuthService(ETheaterContext context, IMapper mapper, ITokenService tokenService, UserManager<Database.User> userManager, SignInManager<Database.User> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<AuthToken> Login(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null || user.IsDeleted == true) throw new eTheaterException("Invalid credentials", "Invalid email or password");

            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, isPersistent: false, lockoutOnFailure: false);
           
            {
                var isCustomer = await _userManager.IsInRoleAsync(user, "User");
                if (isCustomer)
                {
                    var token = _tokenService.GenerateJwtToken(user, "User");
                    return new AuthToken() { Token = token };
                }
            }
            throw new eTheaterException("Invalid credentials", "Invalid email or password");
        }

        public async Task<AuthToken> LoginAdmin(LoginRequest request)
        {
            var admin = await _userManager.FindByEmailAsync(request.Email);
            if (admin == null || admin.IsDeleted == true)
                throw new eTheaterException("Invalid credentials", "Invalid email or password");

            // var result = await _signInManager.PasswordSignInAsync(admin.UserName, request.Password, isPersistent: false, lockoutOnFailure: false);
            // if (result.Succeeded)
            if (await _userManager.CheckPasswordAsync(admin, request.Password))
            {
                var isAdmin = await _userManager.IsInRoleAsync(admin, "Admin");
                if (isAdmin)
                {
                    var token = _tokenService.GenerateJwtToken(admin, "Admin");
                    return new AuthToken() { Token = token };
                }
            }
            throw new eTheaterException("Invalid credentials", "Invalid email or password");
        }

        public async Task<AuthToken> Register(RegisterRequest request)
        {
            var user = new Database.User
            {
                UserName = request.UserName,
                Email = request.Email,
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                string code = result.Errors.ToList()[0].Code;
                string message = result.Errors.ToList()[0].Description;
                throw new eTheaterException(code, message);
            }
            await _userManager.AddToRoleAsync(user, "User");
            var token = _tokenService.GenerateJwtToken(user, "User");
            return new AuthToken() { Token = token };
        }
    }
}
