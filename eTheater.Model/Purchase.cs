using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int? TotalPrice { get; set; }

        public int? NumberOfTickets { get; set; }

        public bool IsPaid { get; set; }

        public string? PaymentIntentId { get; set; }

        public int? UserId { get; set; }

        public virtual User? User { get; set; }

        public int? ShowScheduleId { get; set; }

        public virtual ShowSchedule? ShowSchedule { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
