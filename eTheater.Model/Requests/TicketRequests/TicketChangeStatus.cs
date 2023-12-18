using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class TicketChangeStatus
    {
        [Required]
        public int PurchaseId { get; set; }

        [Required]
        public List<int>? TicketList { get; set; } = new List<int>();
    }
}
