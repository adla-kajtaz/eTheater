using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public string? Seat { get; set; }

        public string? NumberOfRow { get; set; }

        public int? NumberOfSeat { get; set; }

        public bool IsActive { get; set; }

        public int? ShowScheduleId { get; set; }

        public int? PurchaseId { get; set; }

        public virtual Purchase? Purchase { get; set; }

        public virtual ShowSchedule? ShowSchedule { get; set; }

        public bool IsDeleted { get; set; }
    }
}
