using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class ShowActorSearchObject : BaseSearchObject
    {
        public int? ShowId { get; set; }

        public int? ActorId { get; set; }
    }
}
