using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services.Database
{
    public partial class ShowActor : BaseEntity
    {
        public int ShowActorId { get; set; }

        public int? ActorId { get; set; }

        public int? ShowId { get; set; }

        public virtual Actor? Actor { get; set; }

        public virtual Show? Show { get; set; }
    }
}
