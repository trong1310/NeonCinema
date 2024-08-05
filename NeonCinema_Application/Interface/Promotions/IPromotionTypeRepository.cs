using NeonCinema_Application.DataTransferObject.PromotionTypes;
using NeonCinema_Application.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Promotions
{
    public interface IPromotionTypeRepository
    {
        Task<IEnumerable<PromotionTypesDTO>> GetAllAsync(PaginationRequest paginationParams, CancellationToken cancellationToken);
        Task<PromotionTypesDTO> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<PromotionTypesDTO> CreateAsync(PromotionTypeCreateRequest request, CancellationToken cancellationToken);
        Task<PromotionTypesDTO> UpdateAsync(Guid id, PromotionTypeCreateRequest request, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
