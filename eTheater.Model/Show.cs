using eTheater.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class Show
    {
        public int ShowId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string? Picture { get; set; }

        public int Duration { get; set; }

        public string? Director { get; set; }

        public ShowGenre? ShowGenre { get; set; }

        public bool IsDeleted { get; set; }
    }
}
