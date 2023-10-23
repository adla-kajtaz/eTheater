using System;
using System.Collections.Generic;

namespace eTheater.Services.Database;

public partial class Purchase : BaseEntity
{
    public int PurchaseId { get; set; }

    public int? TotalPrice { get; set; }

    public int? NumberOfTickets { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
