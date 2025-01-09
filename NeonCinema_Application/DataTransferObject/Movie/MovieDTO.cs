using NeonCinema_Application.DataTransferObject.ActorMovies;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Movie
{
    public class MovieDTO   
    {
        public Guid ID { get; set; }
        public int? Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StarTime { get; set; }
        public string? Trailer { get; set; }
        public int? AgeAllowed { get; set; }  
        public string Images { get; set; }
		public eSubEnum? Sub { get; set; }
		public MovieStatus? Status { get; set; }
        public string? GenreName { get; set; }
        public string? LanguareName { get; set; }
        public string? CountryName { get; set; }
        public string? DirectorName { get; set; }
        public string? MovieTypeName { get; set; }
        public DateTime? CreateTime { get; set; }
		public List<ActorMoviesDto>? ActorMovies { get; set; }
	}
}
