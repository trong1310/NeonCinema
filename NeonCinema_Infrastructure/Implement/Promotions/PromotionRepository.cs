using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly NeonCenimaContext _context;

        public PromotionRepository(NeonCenimaContext context)
        {
            _context = context;
        }

        public async Task<PaginationResponse<Promotion>> GetAllAsync(PaginationRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Promotion.AsQueryable();

            var totalItems = await query.CountAsync(cancellationToken);
            var items = await query.Skip((request.PageNumber - 1) * request.PageSize)
                                    .Take(request.PageSize)
                                    .ToListAsync(cancellationToken);

            return new PaginationResponse<Promotion>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = totalItems > request.PageNumber * request.PageSize,
                Data = items
            };
        }

        public async Task<Promotion> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Promotion.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task<HttpResponseMessage> AddAsync(Promotion promotion, CancellationToken cancellationToken)
        {
            await _context.Promotion.AddAsync(promotion, cancellationToken);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0 ? new HttpResponseMessage(HttpStatusCode.Created) : new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public async Task<HttpResponseMessage> UpdateAsync(Promotion request, CancellationToken cancellationToken)
        {
            var pro = await _context.Promotion.FirstOrDefaultAsync(x => x.PromotionID == request.PromotionID);
            if (pro == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Movie not found")
                };
            }
            pro.Status = request.Status;
            pro.StarDate = request.StarDate;
            pro.proviso = request.proviso;
            pro.PromotionCustomers = request.PromotionCustomers;
            pro.PromotionID = request.PromotionID;  
            pro.PromotionCode   = request.PromotionCode;
            pro.BillDetail = request.BillDetail;
            pro.Description = request.Description;
            pro.Discount = request.Discount;
            _context.Promotion.Update(pro);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("Updated successfully")
            };
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _context.Promotion.FindAsync(id, cancellationToken);
            if (entity != null)
            {
                _context.Promotion.Remove(entity);
                var result = await _context.SaveChangesAsync(cancellationToken);
                return result > 0 ? new HttpResponseMessage(HttpStatusCode.NoContent) : new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
    }
}
