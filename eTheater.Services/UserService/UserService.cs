using AutoMapper;
using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using eTheater.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class UserService : BaseCRUDService<Model.User, Database.User, UserSearchObject, UserUpdateRequest, UserUpdateRequest>, IUserService
    {
        public UserService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.User> AddFilter(IQueryable<eTheater.Services.Database.User> query, UserSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            if (!string.IsNullOrWhiteSpace(search?.UserName))
                filteredQuery = filteredQuery.Where(x => x.UserName.Contains(search.UserName));
            if (!string.IsNullOrWhiteSpace(search?.Email))
                filteredQuery = filteredQuery.Where(x => x.Email.StartsWith(search.Email));

            return filteredQuery;
        }

        public override Model.User Delete(int id)
        {
            var entity = _context.Users.Find(id);

            if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.User>(entity);
        }

        public override Model.User Update(int id, UserUpdateRequest update)
        {
            var userWithUsername = _context.Users.Where(x => x.Id != id && x.UserName == update.UserName).ToList();
            if (userWithUsername != null && userWithUsername.Count > 0)
            {
                throw new eTheaterException("Username", "Username is already taken!");
            }

            var userWithEmail = _context.Users.Where(x => x.Id != id && x.Email == update.Email).ToList();
            if (userWithEmail != null && userWithEmail.Count > 0)
            {
                throw new eTheaterException("Email", "Email is already taken!");
            }
            return base.Update(id, update);
        }

        public Model.User GetMe(int id)
        {
            var user = _context.Users.Find(id);
            return _mapper.Map<Model.User>(user);
        }

        public Model.UserReport UserPurchaseReport(int userId)
        {
            var purchases = _context.Purchases.Include(x=>x.ShowSchedule).ThenInclude(x=>x.Show).Where(e => e.UserId == userId).ToList();
            int price = 0;
            List<UserPurchases> userPurchasesList = new List<UserPurchases>();
            foreach (var purchase in purchases)
            {
                var userPurchase = new UserPurchases
                {
                    ShowName = purchase.ShowSchedule.Show.Name,
                    NumberOfTickets = purchase.NumberOfTickets,
                    Price = purchase.TotalPrice
                };
                userPurchasesList.Add(userPurchase);
                price += purchase.TotalPrice;
            }

            var report = new UserReport()
            {
                Purchases = userPurchasesList,
                TotalPrice = price
            };

            return report;
        }
    }
}
