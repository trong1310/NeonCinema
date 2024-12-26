namespace NeonCinema_API.Controllers.Service
{
    public class UserProfile
    {
        public Guid ID { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Images { get; set; }
        public double? Ponit { get; set; }
        public int age { get; set; }
    }
}
