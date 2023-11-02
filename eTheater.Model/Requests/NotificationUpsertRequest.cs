using eTheater.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Model.Requests
{
    public class NotificationUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Content { get; set; }

        [Required]
        public string? Picture { get; set; }

        [EnumDataType(typeof(Enums.NotificationCategory))]
        [Required]
        public NotificationCategory? NotificationCategory { get; set; }

        [Required]
        public int? UserId { get; set; }
    }
}
