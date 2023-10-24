using eTheater.Model.Enums;
using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class Notification : BaseEntity
{
    public int NotificationId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? Picture { get; set; }

    public NotificationCategory? NotificationCategory { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
