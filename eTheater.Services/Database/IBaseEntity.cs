using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services.Database
{
    public interface IBaseEntity
    {
        bool IsDeleted { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }


    }
}
