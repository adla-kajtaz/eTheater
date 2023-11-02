using eTheater.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.SearchObjects
{
    public class NotificationSearchObject : BaseSearchObject
    {
        public string? Title { get; set; }

        [Range(1, 3, ErrorMessage = "Invalid category value.")]
        public NotificationCategory? NotificationCategory { get; set; }
    }
}
