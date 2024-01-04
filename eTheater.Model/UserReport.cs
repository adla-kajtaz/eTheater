using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class UserReport
    {
        public List<UserPurchases> Purchases { get; set; }
        public int TotalPrice { get; set; }
    }
}
