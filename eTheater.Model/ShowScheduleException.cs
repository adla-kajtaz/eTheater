using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class ShowScheduleException : Exception
    {
        public string Title { get; set; }

        public ShowScheduleException(string title, string message) : base(message)
        {
            Title = title;
        }
    }
}
