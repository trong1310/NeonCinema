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
        [Required(ErrorMessage = "Không được để trống trường này")]
        public string code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; } = "Không có"; // Mô tả khuyến mãi

        [Range(1, 100, ErrorMessage = "Chỉ được nhập từ 1-100")]
        public double Amount { get; set; } // giảm theo %

        public DateTime TimeStar { get; set; } = DateTime.Now;
		public DateTime TimeEnd { get; set; } = DateTime.Now;

	}
}
