using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public interface IShowService : IBaseCRUDService<Model.Show, ShowSearchObject, ShowUpsertRequest, ShowUpsertRequest>
    {
    }
}
