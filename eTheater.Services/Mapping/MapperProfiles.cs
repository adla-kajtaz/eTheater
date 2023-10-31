﻿using AutoMapper;
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

            CreateMap<HallUpsertRequest, Database.Hall>();
            CreateMap<ShowUpsertRequest, Database.Show>();
            CreateMap<ShowScheduleUpsertRequest, Database.ShowSchedule>();
            CreateMap<TicketUpsertRequest, Database.Ticket>();
            CreateMap<TheaterInfoUpsertRequest, Database.TheaterInfo>();
            CreateMap<UserUpdateRequest, Database.User>();

        }
    }
}