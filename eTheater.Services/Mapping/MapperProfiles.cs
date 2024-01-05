using AutoMapper;
using eTheater.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services.Mapping
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Database.Hall, Model.Hall>();
            CreateMap<Database.Show, Model.Show>();
            CreateMap<Database.ShowSchedule, Model.ShowSchedule>();
            CreateMap<Database.Ticket, Model.Ticket>();
            CreateMap<Database.TheaterInfo, Model.TheaterInfo>();
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.Notification, Model.Notification>();
            CreateMap<Database.Purchase, Model.Purchase>();
            CreateMap<Database.Actor, Model.Actor>();
            CreateMap<Database.ShowActor, Model.ShowActor>();

            CreateMap<HallInsertRequest, Database.Hall>();
            CreateMap<HallUpdateRequest, Database.Hall>();
            CreateMap<ShowUpsertRequest, Database.Show>();
            CreateMap<ShowScheduleInsertRequest, Database.ShowSchedule>();
            CreateMap<ShowScheduleUpdateRequest, Database.ShowSchedule>();
            CreateMap<TicketUpsertRequest, Database.Ticket>();
            CreateMap<TheaterInfoUpsertRequest, Database.TheaterInfo>();
            CreateMap<UserUpdateRequest, Database.User>();
            CreateMap<NotificationUpsertRequest, Database.Notification>();
            CreateMap<PurchaseUpsertRequest, Database.Purchase>();
            CreateMap<ActorUpsertRequest, Database.Actor>();
            CreateMap<ShowActorUpsertRequest, Database.ShowActor>();
        }
    }
}
