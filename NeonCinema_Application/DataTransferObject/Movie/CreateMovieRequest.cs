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
		[Required(ErrorMessage = "Thời lượng không được để trống")]
		[Range(1, int.MaxValue, ErrorMessage = "Thời lượng phải lớn hơn 0")]
		public int Duration { get; set; }
		[Required(ErrorMessage = "Tên phim không được để trống")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Mô tả không được để trống")]
		public string Description { get; set; }
		[Required(ErrorMessage = "Thời gian bắt đầu không được để trống")]
		[DataType(DataType.Date)]
		[FutureDate(ErrorMessage = "Ngày phát hành không được nhỏ hơn ngày hiện tại")]
		public DateTime StarTime { get; set; }
		[Required(ErrorMessage = "Trailer không được để trống")]
		public string Trailer { get; set; }
		public string Images { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Tuổi phải lớn hơn 0")]
		public int AgeAllowed { get; set; }
		[Required(ErrorMessage = "Thể loại không được để trống")]
		public Guid GenreID { get; set; }
		[Required(ErrorMessage = "Ngôn ngữ không được để trống")]
		public Guid LenguageID { get; set; }
		[Required(ErrorMessage = "Quốc gia không được để trống")]
		public Guid CountryID { get; set; }
		[Required(ErrorMessage = "Đạo diễn không được để trống")]
		public Guid DirectorID { get; set; }
        [Required(ErrorMessage = "Đạo diễn không được để trống")]
        public Guid Actor { get; set; }
    }
	public class FutureDateAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is DateTime dateTime)
			{
				if (dateTime < DateTime.Today)
				{
					return new ValidationResult(ErrorMessage);
				}
			}
			return ValidationResult.Success;
		}
	}
}
