using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class TheaterInfo : BaseEntity
{
    public int TheaterInfoId { get; set; }

    public string? Name { get; set; }

    public string? Logo { get; set; }

    public string? Adress { get; set; }

    public string? Email { get; set; }

    public string? Webpage { get; set; }

    public string? PhoneNumber { get; set; }
}
