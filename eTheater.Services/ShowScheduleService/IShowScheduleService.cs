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
    public interface IShowScheduleService : IBaseCRUDService<Model.ShowSchedule, ShowScheduleSearchObject, ShowScheduleInsertRequest, ShowScheduleUpdateRequest>
    {
        List<string> GetTimeSlotsForDate(int hallId, DateTime date);
        List<string> GetTimeSlotsForDate2(int hallId, DateTime date, int showScheduleId);
        List<Model.ShowSchedule> ShowScheduleRecommenderSystem(int userId);
        void DeleteTicketsByShowScheduleId(int id);
    }
}
