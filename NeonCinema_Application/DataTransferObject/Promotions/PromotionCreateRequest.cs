using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
    public class PromotionCreateRequest
    {
		public Guid ID { get; set; }  // Khóa chính
        public string Code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; } = "Không có"; // Mô tả khuyến mãi

        [Range(1, 100, ErrorMessage = "Chỉ được nhập từ 1-100")]
        public double DiscountAmount { get; set; } // giảm theo %

		[Required(ErrorMessage = "Start date is required.")]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; } = DateTime.Now;

		[Required(ErrorMessage = "End date is required.")]
		[DataType(DataType.Date)]
		[DateRangeValidation]  // Sử dụng thuộc tính xác thực tùy chỉnh
		public DateTime EndDate { get; set; } = DateTime.Now;

	}

	public class DateRangeValidationAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var instance = (PromotionCreateRequest)validationContext.ObjectInstance;

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
