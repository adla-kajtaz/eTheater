using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class ShowGenre : BaseEntity
{
    public int ShowGenreId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Show> Shows { get; set; } = new List<Show>();
}
