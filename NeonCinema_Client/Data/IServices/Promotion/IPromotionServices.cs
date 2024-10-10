using NeonCinema_Application.DataTransferObject.Promotions;

namespace NeonCinema_Client.Data.IServices.Promotion
{
    public interface IPromotionServices
    {
        Task<List<PromotionDTO>> GetPromotionListAsync();
    }
}
