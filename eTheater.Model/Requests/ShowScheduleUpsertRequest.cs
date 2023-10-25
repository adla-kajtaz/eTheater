using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class ShowScheduleUpsertRequest
    {
        [Range(10, double.MaxValue, ErrorMessage = "Price cannot be less then or equal to 10.")]
        [Required]
        public int TicketPrice { get; set; }

        [Required]
        public DateTime ShowDate { get; set; }

        [Required]
        public string ShowTime { get; set; }

        [Required]
        public int? ShowId { get; set; }

        [Required]
        public int? HallId { get; set; }
    }
}
