using eTheater.Model.Enums;
using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class Show : BaseEntity
{
    public int ShowId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public int Duration { get; set; }

    public string? Director { get; set; }

    public ShowGenre? ShowGenre { get; set; }

    public virtual ICollection<ShowSchedule> ShowSchedules { get; set; } = new List<ShowSchedule>();

    public virtual ICollection<ShowActor> ShowActors { get; set; } = new List<ShowActor>();

}
