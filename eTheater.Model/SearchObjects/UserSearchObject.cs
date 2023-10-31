using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class UserSearchObject : BaseSearchObject
    {
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public int? UserId { get; set; }
    }
}
