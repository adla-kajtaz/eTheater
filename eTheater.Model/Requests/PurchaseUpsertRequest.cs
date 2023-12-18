using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class PurchaseUpsertRequest
    {
        public int? ShowScheduleId { get; set; }

        public List<int> Tickets { get; set; }
    }
}
