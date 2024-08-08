using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.PromotionCustomer
{
    public class PromotionCustomerRepository : IPromotionCustomerRepository
    {
        private readonly NeonCenimaContext _context;

        public PromotionCustomerRepository(NeonCenimaContext context)
        {
            _context = context;
        }

        public async Task<HttpResponseMessage> AddAsync(NeonCinema_Domain.Database.Entities.PromotionCustomer promotionCustomer, CancellationToken cancellationToken)
        {
            promotionCustomer.PromotionId = Guid.NewGuid();
            await _context.PromotionCustomers.AddAsync(promotionCustomer, cancellationToken);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0 ? new HttpResponseMessage(HttpStatusCode.Created) : new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid promotionId, Guid customerId, CancellationToken cancellationToken)
        {
            var entity = await _context.PromotionCustomers
            .FirstOrDefaultAsync(pc => pc.PromotionId == promotionId && pc.ID == customerId, cancellationToken);
            if (entity != null)
            {
                _context.PromotionCustomers.Remove(entity);
                var result = await _context.SaveChangesAsync(cancellationToken);
                return result > 0 ? new HttpResponseMessage(HttpStatusCode.NoContent) : new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
    

        public async Task<PaginationResponse<NeonCinema_Domain.Database.Entities.PromotionCustomer>> GetAllAsync(PaginationRequest request, CancellationToken cancellationToken)
        {
            var query = _context.PromotionCustomers.AsQueryable();

            var totalItems = await query.CountAsync(cancellationToken);
            var items = await query.Skip((request.PageNumber - 1) * request.PageSize)
                                    .Take(request.PageSize)
                                    .ToListAsync(cancellationToken);

            return new PaginationResponse<NeonCinema_Domain.Database.Entities.PromotionCustomer>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = totalItems > request.PageNumber * request.PageSize,
                Data = items
            };
        }

        public async Task<NeonCinema_Domain.Database.Entities.PromotionCustomer> GetByIdAsync(Guid promotionId, Guid customerId, CancellationToken cancellationToken)
        {
            return await _context.PromotionCustomers
            .FirstOrDefaultAsync(pc => pc.PromotionId == promotionId && pc.ID == customerId, cancellationToken);
        }

        public async Task<HttpResponseMessage> UpdateAsync(NeonCinema_Domain.Database.Entities.PromotionCustomer promotionCustomer, CancellationToken cancellationToken)
        {
            var obj = await _context.PromotionCustomers.FirstOrDefaultAsync(pc => pc.ID == promotionCustomer.ID, cancellationToken);
            if (obj == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("không tìm thấy")
                };
            }
            obj.Status = promotionCustomer.Status;
            _context.PromotionCustomers.Update(obj);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("update successfully")
            };
        }
    }
}
