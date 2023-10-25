using eTheater.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class ShowSearchObject : BaseSearchObject
    {
        public string? Name { get; set; }

        [Range(1, 5, ErrorMessage = "Invalid genre value.")]
        public ShowGenre? ShowGenre { get; set; }
    }
}
