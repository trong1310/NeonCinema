using NeonCinema_Domain.Enum;

namespace NeonCinema_API.Controllers.Service
{
    public class UpdateUserProfileRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Images { get; set; }
    }
}
