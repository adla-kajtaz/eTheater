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
        public string UserName { get; set; }

        [Required]
        [EmailAddress()]
        public string Email { get; set; }
    }
}
