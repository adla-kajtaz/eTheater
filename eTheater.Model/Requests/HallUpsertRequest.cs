using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class HallUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Total seats cannot be less then or equal to 0.")]
        [Required]
        public int TotalSeats { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Total rows cannot be less then or equal to 0.")]
        [Required]
        public int TotalRows { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Number of seats per row cannot be less then or equal to 0.")]
        [Required]
        public int NumberOfSeatsPerRow { get; set; }
    }
}
