using NeonCinema_Application.DataTransferObject.Promotions;

namespace NeonCinema_Client.Data.IServices.Promotion
{
    public interface IPromotionServices
    {
        Task<List<PromotionDTO>> GetPromotionListAsync();
        Task<bool> CreatePromotionAsync(PromotionCreateRequest input);
        Task<bool> DeletePromotionAsync(Guid id);
        //Task<string> Validate(PromotionCreateRequest input);
    }
}
