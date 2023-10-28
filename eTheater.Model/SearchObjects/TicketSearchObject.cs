using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class TicketSearchObject : BaseSearchObject
    {
        public int? ShowScheduleId { get; set; }
        public bool? IsActive { get; set; }
    }
}
