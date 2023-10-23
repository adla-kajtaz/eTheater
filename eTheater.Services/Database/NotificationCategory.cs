using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class NotificationCategory : BaseEntity
{
    public int NotificationCategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
