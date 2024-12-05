using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers.Service
{
    public interface IUserServices
    {
        Task<UserProfile> GetUserProfileAsync(Guid userId);
        Task<Users> UpdateProfileAsync(Guid userId, UpdateUserProfileRequest request);
    }
}
