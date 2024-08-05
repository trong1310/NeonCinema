using NeonCinema_Application.DataTransferObject.Promotions;
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
        Task<List<PromotionDTO>> GetAllPromotionsAsync(Guid id,CancellationToken cancellationToken);
        Task<PromotionDTO> GetPromotionByIdAsync(Guid id , CancellationToken cancellationToken);
        Task<bool>AddPromotionAsync(Promotion promotion, CancellationToken cancellationToken);
        Task<bool> UpdatePromotionAsync(Promotion promotion, CancellationToken cancellationToken);
        Task<bool> DeletePromotionAsync(Guid id, CancellationToken cancellationToken);
    }
}
