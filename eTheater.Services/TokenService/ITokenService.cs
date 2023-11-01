using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public interface ITokenService
    {
        string GenerateJwtToken(Database.User user, string role);
    }
}
