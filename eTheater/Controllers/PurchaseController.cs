﻿using eTheater.Model;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eTheater.Controllers
{
    public class PurchaseController : BaseCRUDController<Model.Purchase, PurchaseSearchObject, PurchaseUpsertRequest, PurchaseUpsertRequest>
    {
        public IPurchaseService _service { get; set; }

        public PurchaseController(IPurchaseService service) : base(service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet("GetByUserId/{id}")]
        public IEnumerable<Model.Purchase> GetByUserId(int id)
        {
            return _service.GetByUserId(id);
        }

        public override Purchase Delete(int id)
        {
            throw new UserException("Not allowed", "Deleting purchase is not allowed");
        }
    }
}
