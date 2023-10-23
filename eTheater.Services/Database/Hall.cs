using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class Hall : BaseEntity
{
    public int HallId { get; set; }

    public string? Name { get; set; }

    public int? TotalSeats { get; set; }

    public int? TotalRows { get; set; }

    public int? NumberOfSeatsPerRow { get; set; }

    public virtual ICollection<ShowSchedule> ShowSchedules { get; set; } = new List<ShowSchedule>();
}
