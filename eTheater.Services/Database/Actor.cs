using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services.Database
{
    public partial class Actor : BaseEntity
    {
        public int ActorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
