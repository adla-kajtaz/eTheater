﻿using AutoMapper;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using eTheater.Services.Database;

namespace eTheater.Services
{
    public class HallService : BaseCRUDService <Model.Hall, Database.Hall, HallSearchObject, HallInsertRequest, HallUpdateRequest>, IHallService
    {
        public HallService(ETheaterContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eTheater.Services.Database.Hall> AddFilter(IQueryable<eTheater.Services.Database.Hall> query, HallSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
                filteredQuery = filteredQuery.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.Hall Insert(HallInsertRequest request)
        {
            Database.Hall hall = new Database.Hall();
            hall.Name = request.Name;
            hall.TotalRows = request.TotalRows;
            hall.NumberOfSeatsPerRow = request.NumberOfSeatsPerRow;
            hall.TotalSeats = request.TotalRows * request.NumberOfSeatsPerRow;
            _context.Add(hall);
            _context.SaveChanges();
            return _mapper.Map<Model.Hall>(hall);
        }

        public override Model.Hall Delete(int id)
        {
            var entity = _context.Halls.Find(id);
            var showSchedules = _context.ShowSchedules.Where(e => e.HallId == id).ToList();

            if (showSchedules != null && showSchedules.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Hall>(entity);
        }
    }
}
