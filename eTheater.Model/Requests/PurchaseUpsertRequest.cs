using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class PurchaseUpsertRequest
    {
        public int? TotalPrice { get; set; }

        public int? UserId { get; set; }

        public int? ShowScheduleId { get; set; }

        public List<int> Tickets { get; set; }
    }
}
