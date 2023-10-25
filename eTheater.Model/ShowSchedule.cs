using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class ShowSchedule
    {
        public int ShowScheduleId { get; set; }

        public int? TicketPrice { get; set; }

        public DateTime? ShowDate { get; set; }

        public string? ShowTime { get; set; }

        public int? ShowId { get; set; }

        public int? HallId { get; set; }

        public virtual Hall? Hall { get; set; }

        public virtual Show? Show { get; set; }

        public bool IsDeleted { get; set; }
    }
}
