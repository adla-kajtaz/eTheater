using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class Hall
    {
        public int HallId { get; set; }

        public string Name { get; set; }

        public int TotalSeats { get; set; }

        public int TotalRows { get; set; }

        public int NumberOfSeatsPerRow { get; set; }

        public bool IsDeleted { get; set; }
    }
}
