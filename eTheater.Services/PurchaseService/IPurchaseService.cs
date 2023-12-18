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
    public interface IPurchaseService : IBaseCRUDService<Model.Purchase, PurchaseSearchObject, PurchaseUpsertRequest, PurchaseUpsertRequest>
    {
        Model.Purchase Insert(int userId, PurchaseUpsertRequest request);
        IEnumerable<Model.Purchase> GetByUserId(int id);
        Model.Purchase ChangeTicketStatus(TicketChangeStatus tcs);
    }
}
