using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model
{
    public class RecommendationException : Exception
    {
        public RecommendationException(string message) : base(message)
        {

        }
    }
}
