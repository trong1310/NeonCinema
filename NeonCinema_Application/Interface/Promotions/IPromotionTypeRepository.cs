using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Promotions
{
    public interface IPromotionTypeRepository
    {

        Task<PaginationResponse<PromotionType>> GetAllAsync(PaginationRequest request, CancellationToken cancellationToken);
        Task<PromotionType> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> AddAsync(PromotionType promotionType, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateAsync(PromotionType promotionType, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
