using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class Ticket : BaseEntity
{
    public int TicketId { get; set; }

    public string? Seat { get; set; }

    public string? NumberOfRow { get; set; }

    public int? NumberOfSeat { get; set; }

    public bool IsActive { get; set; } = true;

    public int? ShowScheduleId { get; set; }

    public int? PurchaseId { get; set; }

    public virtual Purchase? Purchase { get; set; }

    public virtual ShowSchedule? ShowSchedule { get; set; }
}
