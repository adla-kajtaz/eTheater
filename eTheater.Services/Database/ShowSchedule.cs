using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class ShowSchedule : BaseEntity
{
    public int ShowScheduleId { get; set; }

    public int? TicketPrice { get; set; }

    public DateTime ShowDate { get; set; }

    public string? ShowTime { get; set; }

    public int? ShowId { get; set; }

    public int? HallId { get; set; }

    public virtual Hall? Hall { get; set; }

    public virtual Show? Show { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
