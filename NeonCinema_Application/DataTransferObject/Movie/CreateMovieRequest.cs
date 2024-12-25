using Microsoft.AspNetCore.Http;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Movie
{
	public class CreateMovieRequest
	{
		public int Duration { get; set; }
		public string Name { get; set; }
		public bool Sub { get; set; }
		public string Description { get; set; }
		public DateTime StarTime { get; set; }
		public string Trailer { get; set; }
		public string Images { get; set; }
		public int AgeAllowed { get; set; }
		public Guid GenreID { get; set; }
		public Guid LenguageID { get; set; }
		public Guid CountryID { get; set; }
		public Guid DirectorID { get; set; }
		public List<Guid>? ActorMovies { get; set; }
	}

}