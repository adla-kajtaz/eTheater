using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class BaseSearchObject
    {
        public int? Page { set; get; }
        public int? PageSize { get; set; }
    }
}
