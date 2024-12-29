using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
    public class PromotionDTO
    {
        public Guid ID { get; set; }  // Khóa chính

		[Required(ErrorMessage = "Không được để trống trường này")]
		[RegularExpression(@"^[\p{L}0-9 /]*$", ErrorMessage = "Chỉ được chứa chữ cái, số, khoảng trắng, và dấu /")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Không được để trống trường này")]
		public string Code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi

		[ConditionalRange(1, 100, ErrorMessage = "Chỉ được nhập từ 1-100")]
		public double? DiscountPercentage { get; set; } // giảm theo %

		[ConditionalRange(5000, 100000, ErrorMessage = "Chỉ được nhập từ 5-100 nghìn")]
		public double? DiscountAmount { get; set; } // giảm theo gia

		public double? AmountMax { get; set; }

		[Required(ErrorMessage = "Không được để trống trường này")]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		[Required(ErrorMessage = "Không được để trống trường này")]
		[DataType(DataType.Date)]
		[DateRangeUpdateValidation]  // Sử dụng thuộc tính xác thực tùy chỉnh
		public DateTime EndDate { get; set; }
        public PromotionStatus Status { get; set; }

		//không sử dụng cho update
		public DateTime? CreatedTime { get; set; }
    }

	public class DateRangeUpdateValidationAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var instance = (PromotionDTO)validationContext.ObjectInstance;

			// Kiểm tra giá trị StartDate
			if (instance.StartDate < DateTime.Now.Date)
			{
				return new ValidationResult("Ngày bắt đầu không thể là quá khứ");
			}

			// Kiểm tra giá trị EndDate
			if (instance.EndDate <= instance.StartDate)
			{
				return new ValidationResult("ngày kết thúc phải lớn hơn ngày bắt đầu");
			}

			// Kiểm tra EndDate phải lớn hơn StartDate ít nhất 1 ngày
			if ((instance.EndDate - instance.StartDate).TotalDays < 1)
			{
				return new ValidationResult("Ngày kết thúc phải lớn hơn ngày bắt đầu 1 ngày");
			}

			return ValidationResult.Success;
		}
	}


}
