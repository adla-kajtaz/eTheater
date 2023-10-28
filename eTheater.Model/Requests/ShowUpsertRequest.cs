using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using eTheater.Model.Enums;

namespace eTheater.Model.Requests
{
    public class ShowUpsertRequest
    {
        [MinLength(3)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Required]
        public string? Picture { get; set; }

        [Range(10, 60, ErrorMessage = "Duration cannot be less then or equal to 10 or greater than 60.")]
        [Required]
        public int Duration { get; set; }

        [Required]
        public string? Director { get; set; }

        [EnumDataType(typeof(Enums.ShowGenre))]
        [Required]
        public ShowGenre? ShowGenre { get; set; } = Enums.ShowGenre.Drama;
    }
}
