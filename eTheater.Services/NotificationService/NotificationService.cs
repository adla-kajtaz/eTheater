using AutoMapper;
using eTheater.Model.Enums;
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
    public class NotificationService : BaseCRUDService<Model.Notification, Database.Notification, NotificationSearchObject, NotificationUpsertRequest, NotificationUpsertRequest>, INotificationService
    {
        public NotificationService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.Notification> AddInclude(IQueryable<eTheater.Services.Database.Notification> query, NotificationSearchObject search = null)
        {
            query = query.Include(x => x.User);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eTheater.Services.Database.Notification> AddFilter(IQueryable<eTheater.Services.Database.Notification> query, NotificationSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Title))
                filteredQuery = filteredQuery.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            if (search?.NotificationCategory != NotificationCategory.All)
                filteredQuery = filteredQuery.Where(x => x.NotificationCategory == search.NotificationCategory);
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.Notification Delete(int id)
        {
            var entity = _context.Notifications.Find(id);
            if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Notification>(entity);
        }
    }
}
