using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class TheaterInfo
    {
        public int TheaterInfoId { get; set; }

        public string? Name { get; set; }

        public string? Logo { get; set; }

        public string? Adress { get; set; }

        public string? Email { get; set; }

        public string? Webpage { get; set; }

        public string? PhoneNumber { get; set; }

        public bool IsDeleted { get; set; }
    }
}
