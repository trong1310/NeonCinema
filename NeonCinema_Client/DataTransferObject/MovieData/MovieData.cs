using NeonCinema_Domain.Enum;

namespace NeonCinema_Client.DataTransferObject.MovieData
{
    public class MovieData
    {
        public int? Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StarTime { get; set; }
        public string? Trailer { get; set; }
        public int? AgeAllowed { get; set; }
        public string? Images { get; set; }
        public MovieStatus? Status { get; set; }
        public string? GenreName { get; set; }
        public string? LanguareName { get; set; }
        public string? CountryName { get; set; }
        public string? DirectorName { get; set; }
    }
}
