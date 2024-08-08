using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.PromotionTypes
{
    public class PromotionTypeRepository : IPromotionTypeRepository

    {
        private readonly NeonCenimaContext _context;

        public PromotionTypeRepository(NeonCenimaContext context)
        {
                _context = context;

        }
        public async Task<PaginationResponse<PromotionType>> GetAllAsync(PaginationRequest request, CancellationToken cancellationToken)
        {
            var query = _context.PromotionTypes.AsQueryable();

            var totalItems = await query.CountAsync(cancellationToken);
            var items = await query.Skip((request.PageNumber - 1) * request.PageSize)
                                    .Take(request.PageSize)
                                    .ToListAsync(cancellationToken);

            return new PaginationResponse<PromotionType>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = totalItems > request.PageNumber * request.PageSize,
                Data = items
            };
        }
        public async Task<HttpResponseMessage> AddAsync(PromotionType promotionType, CancellationToken cancellationToken)
        {
            promotionType.PromotionTypeID = Guid.NewGuid();
            await _context.PromotionTypes.AddAsync(promotionType, cancellationToken);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("Add successfully")
            };
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _context.PromotionTypes.FindAsync(new object[] { id }, cancellationToken);
            if (entity != null)
            {
                _context.PromotionTypes.Remove(entity);
                var result = await _context.SaveChangesAsync(cancellationToken);
                return result > 0 ? new HttpResponseMessage(HttpStatusCode.NoContent) : new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

      

        public async Task<PromotionType> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.PromotionTypes.FindAsync(id, cancellationToken);
        }

        public async Task<HttpResponseMessage> UpdateAsync(PromotionType promotionType, CancellationToken cancellationToken)
        {
            var obj = await _context.PromotionTypes.FirstOrDefaultAsync(x => x.PromotionTypeID == promotionType.PromotionTypeID);
           
            if (obj == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(" Không tìm thấy")
                };

            }
          
            _context.PromotionTypes.Update(obj);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("Updated successfully")
            };
        }
    }
}
