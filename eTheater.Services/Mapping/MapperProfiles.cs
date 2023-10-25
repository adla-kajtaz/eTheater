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


            CreateMap<HallUpsertRequest, Database.Hall>();
            CreateMap<ShowUpsertRequest, Database.Show>();
            CreateMap<ShowScheduleUpsertRequest, Database.ShowSchedule>();
        }
    }
}
