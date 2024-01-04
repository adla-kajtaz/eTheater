using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public interface IUserService : IBaseCRUDService<Model.User, UserSearchObject, UserUpdateRequest, UserUpdateRequest>
    {
        Model.User GetMe(int id);
        Model.UserReport UserPurchaseReport(int userId);
    }
}
