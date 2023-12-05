using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class UserUpdateRequest
    {
        [Required]
        [MinLength(4, ErrorMessage = "Username must contain at least 4 characters!")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress()]
        public string Email { get; set; }
    }
}
