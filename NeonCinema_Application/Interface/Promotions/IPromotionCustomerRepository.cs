using NeonCinema_Application.DataTransferObject.PromotionCustomers;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Promotions
{
    public interface IPromotionCustomerRepository
    {
        Task<PaginationResponse<PromotionCustomer>> GetAllAsync(PaginationRequest request, CancellationToken cancellationToken);
        Task<PromotionCustomer> GetByIdAsync(Guid promotionId, Guid customerId, CancellationToken cancellationToken);
        Task<HttpResponseMessage> AddAsync(PromotionCustomer promotionCustomer, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateAsync(PromotionCustomer promotionCustomer, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteAsync(Guid promotionId, Guid customerId, CancellationToken cancellationToken);
    }
}
