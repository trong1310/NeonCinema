using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Application.DataTransferObject.User;

namespace NeonCinema_Client.Data.IServices.Promotion
{
    public interface IPromotionServices
    {
        Task<List<PromotionDTO>> GetPromotionListAsync();
        Task<PromotionDTO> GetPromotionByIdAsync(Guid id);
        Task<List<PromotionDTO>> SearchProByNameAsync(string input);
        Task<bool> CreatePromotionAsync(PromotionCreateRequest input);
        Task<bool> UpdatePromotionAsync(PromotionDTO input);
        Task<bool> DeletePromotionAsync(Guid id);
        Task<List<UserDTO>> GetAllUserAsync(string input);
        //Task<string> Validate(PromotionCreateRequest input);
    }
}
