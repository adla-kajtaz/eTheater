using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class HallUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
