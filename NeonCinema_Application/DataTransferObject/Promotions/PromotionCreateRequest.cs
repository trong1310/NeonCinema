﻿using System;
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
		[Required(ErrorMessage = "Không được để trống tên khuyến mại")]
		[RegularExpression(@"^[\p{L}0-9 /]*$", ErrorMessage = "Chỉ được chứa chữ cái, số, khoảng trắng, và dấu /")]
		public string Name { get; set; }  // Tên khuyến mãi
		public string Code { get; set; }  
        public string Description { get; set; } = "Không có"; // Mô tả khuyến mãi

		[Required(ErrorMessage = "Không được để trống phần trăm khuyến mại")]
		[ConditionalRange(1, 99, ErrorMessage = "Chỉ được nhập từ 1-99")]
		public double? DiscountPercentage { get; set; } // giảm theo %

		[ConditionalRange(5000, 100000, ErrorMessage = "Chỉ được nhập từ 5-100 nghìn")]
		public double? DiscountAmount { get; set; }

		[Required(ErrorMessage = "Không được để trống số tiền giảm tối đa")]
		[ConditionalRange(5000, 100000, ErrorMessage = "Chỉ được nhập từ 5 nghìn đến 100 nghìn")]
		public double? AmountMax { get; set; }

		[Required(ErrorMessage = "Không được để trống trường này")]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; } = DateTime.Now;


		[Required(ErrorMessage = "Không được để trống trường này")]
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

	public class ConditionalRangeAttribute : ValidationAttribute
	{
		private readonly double _min;
		private readonly double _max;

		public ConditionalRangeAttribute(double min, double max)
		{
			_min = min;
			_max = max;
		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return ValidationResult.Success;
			}

			if (value is double doubleValue && (doubleValue < _min || doubleValue > _max))
			{
				return new ValidationResult(ErrorMessage ?? $"Giá trị phải từ {_min} đến {_max}");
			}

			return ValidationResult.Success;
		}
	}
}
