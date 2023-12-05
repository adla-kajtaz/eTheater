﻿using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eTheater.Controllers
{
    public class ShowScheduleController : BaseCRUDController<Model.ShowSchedule, ShowScheduleSearchObject, ShowScheduleUpsertRequest, ShowScheduleUpsertRequest>
    {
        public IShowScheduleService _service { get; set; }
        public ShowScheduleController(IShowScheduleService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("getTimeSlotsForDate")]
        public List<string> GetTimeSlotsForDate(int hallId, string date)
        {
            return _service.GetTimeSlotsForDate(hallId, date);
        }

        [Authorize]
        [HttpGet("recommend")]
        public List<Model.ShowSchedule> Recommend()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return _service.ShowScheduleRecommenderSystem(userId);
        }

        [Authorize]
        [HttpGet("deleteTickets/{id}")]
        public void DeleteTickets(int id)
        {
           _service.DeleteTicketsByShowScheduleId(id);
        }

        [Authorize]
        [HttpGet("revenuesPerShowReport/{id}")]
        public Model.RevenuesPerShow RevenuesPerShowReport(int id)
        {
            return _service.RevenuesPerShowReport(id);
        }
    }
}
