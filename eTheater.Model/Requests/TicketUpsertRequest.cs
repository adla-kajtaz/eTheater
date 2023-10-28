using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class TicketUpsertRequest
    {
        [MinLength(2)]
        [Required]
        public string Seat { get; set; }

        [MaxLength(1)]
        [Required]
        public string NumberOfRow { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Number of seat cannot be less then or equal to 0.")]
        [Required]
        public int NumberOfSeat { get; set; }

        [Required]
        public int? ShowScheduleId { get; set; }
    }
}
