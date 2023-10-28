using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class TheaterInfoUpsertRequest
    {

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required]
        public string Logo { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Adress { get; set; }

        [EmailAddress()]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Webpage { get; set; }

        [RegularExpression("^\\d{3}-\\d{3}-(\\d{4}|\\d{3})$", ErrorMessage = "The phone number must be in the form 06X-XXX-XXX !")]
        [Required(AllowEmptyStrings = false)]
        public string PhoneNumber { get; set; }
    }
}
