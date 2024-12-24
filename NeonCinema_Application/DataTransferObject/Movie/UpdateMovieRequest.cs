using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
		public string Images { get; set; }
		public int AgeAllowed { get; set; }
		public Guid GenreID { get; set; }
		public Guid LenguageID { get; set; }
		public Guid CountryID { get; set; }
		public Guid DirectorID { get; set; }
		public MovieStatus Status { get; set; }
		public List<Guid>? ActorMovies { get; set; }
	}
	public class FutureDateAttributes : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is DateTime dateTime)
			{
				if (dateTime.Date > DateTime.Now.Date.AddDays(1))
				{
					return ValidationResult.Success;
				}
				else
				{
					return new ValidationResult(ErrorMessage ?? "Ngày phải lớn hơn hôm nay ít nhất 1 ngày.");
				}
			}
			return new ValidationResult("Giá trị không hợp lệ.");
		}
	}
}
