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
		public string Code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi

		[Range(1, 100, ErrorMessage = "Chỉ được nhập từ 1-100")]
		public double DiscountAmount { get; set; } // giảm theo %

		[Required(ErrorMessage = "Start date is required.")]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		[Required(ErrorMessage = "End date is required.")]
		[DataType(DataType.Date)]
		[DateRangeValidation]  // Sử dụng thuộc tính xác thực tùy chỉnh
		public DateTime EndDate { get; set; }
        public PromotionStatus Status { get; set; }
    }
}
