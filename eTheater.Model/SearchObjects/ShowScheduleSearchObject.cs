using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class ShowScheduleSearchObject : BaseSearchObject
    {
        public string? ShowName { get; set; }

        public int? ShowId { get; set; }

        public int? HallId { get; set; }

        public DateTime? ShowDate { get; set; }
    }
}
