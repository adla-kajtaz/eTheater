using eTheater.Model;
using eTheater.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public interface IAuthService
    {
        Task<AuthToken> Register(RegisterRequest request);
        Task<AuthToken> Login(LoginRequest request);
        Task<AuthToken> LoginAdmin(LoginRequest request);
    }
}
