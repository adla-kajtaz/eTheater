using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class Helper
    {
        public static List<string> getTimeSlots()
        {
            List<string> timeSlots = new List<string>()
        {
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00",
            "18:00-20:00",
            "20:00-22:00",
        };
            return timeSlots;
        }
    }
}
