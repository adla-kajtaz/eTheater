﻿using AutoMapper;
using eTheater.Model.Requests;
using eTheater.Model.SearchObjects;
using eTheater.Services.BaseService;
using eTheater.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class PurchaseService : BaseCRUDService<Model.Purchase, Database.Purchase, PurchaseSearchObject, PurchaseUpsertRequest, PurchaseUpsertRequest>, IPurchaseService
    {

        public StripeService _stripeService { get; set; }
        public PurchaseService(StripeService stripeService, ETheaterContext context, IMapper mapper) : base(context, mapper)
        {
            _stripeService = stripeService;
        }

        public override IQueryable<eTheater.Services.Database.Purchase> AddInclude(IQueryable<eTheater.Services.Database.Purchase> query, PurchaseSearchObject search = null)
        {
            query = query.Include(x => x.User).Include(x=>x.ShowSchedule).Include(x=>x.ShowSchedule.Show).Include(x=>x.ShowSchedule.Hall);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eTheater.Services.Database.Purchase> AddFilter(IQueryable<eTheater.Services.Database.Purchase> query, PurchaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.UserId != null)
                filteredQuery = filteredQuery.Where(x => x.UserId == search.UserId);
            filteredQuery = filteredQuery.Where(x => x.IsDeleted == false);
            return filteredQuery;
        }

        public override Model.Purchase Delete(int id)
        {
            var entity = _context.Purchases.Find(id);
            if (entity == null)
            {
                return null;
            }
            else
            {
                entity.IsDeleted = true;
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Purchase>(entity);
        }

        public IEnumerable<Model.Purchase> GetByUserId(int id)
        {
            var entity = _context.Purchases.Include(x => x.ShowSchedule).Include(x => x.ShowSchedule.Show).Include(x => x.ShowSchedule.Hall).Include(x => x.User).Where(x => x.UserId == id).Where(x => x.IsPaid == true).AsQueryable();
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Purchase>>(list);
        }

        public override Model.Purchase Insert(PurchaseUpsertRequest request)
        {
            var showSchedule = _context.Purchases.First(x => x.ShowScheduleId == request.ShowScheduleId);
            if (showSchedule == null)
                throw new Exception("Show schedule not found");

            Purchase purchase = new Purchase();
            purchase.UserId = request.UserId;
            purchase.NumberOfTickets = request.Tickets.Count();
            purchase.TotalPrice = request.TotalPrice;
            purchase.ShowScheduleId = request.ShowScheduleId;
            _context.Add(purchase);
            _context.SaveChanges();

            var paymentId = _stripeService.CreatePurchase(purchase.TotalPrice, $"Purchase for ({purchase.CreatedAt})");
            purchase.PaymentIntentId = paymentId;

            _context.SaveChanges();
            return _mapper.Map<Model.Purchase>(purchase);
        }
    }
}
