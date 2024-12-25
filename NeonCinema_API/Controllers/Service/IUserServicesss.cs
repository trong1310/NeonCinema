using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers.Service
{
    public interface IUserServicesss
    {
        Task<UserProfile> GetUserProfileAsync(Guid userId);
        Task<Users> UpdateProfileAsync(Guid userId, UpdateUserProfileRequest request);
        
        Task<UserProfile> GetUserProfilec(Guid userId);


    }
}
