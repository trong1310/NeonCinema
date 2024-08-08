using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IPromotionRepository
    {
        Task<PaginationResponse<Promotion>> GetAllAsync(PaginationRequest request, CancellationToken cancellationToken);
        Task<Promotion> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> AddAsync(Promotion promotion, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateAsync(Promotion promotion, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
