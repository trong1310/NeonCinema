using Microsoft.AspNetCore.Http;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Movie
{
    public class UpdateMovieRequest
    {
        public  Guid ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StarTime { get; set; }
        public string Trailer { get; set; }
        public int AgeAllowed { get; set; }
        public IFormFile Images { get; set; }
        public MovieStatus Status { get; set; } = MovieStatus.Active;
        public Guid GenreID { get; set; }
        public Guid LenguageID { get; set; }
        public Guid CountryID { get; set; }
        public Guid DirectorID { get; set; }
    }
}
