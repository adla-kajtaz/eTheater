﻿using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public interface INotificationService : IBaseCRUDService<Model.Notification, NotificationSearchObject, NotificationUpsertRequest, NotificationUpsertRequest>
    {
    }
}
