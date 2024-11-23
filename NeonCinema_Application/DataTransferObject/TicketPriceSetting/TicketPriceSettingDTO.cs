using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.TicketPriceSetting
{
	public class TicketPriceSettingDTO
	{
		public Guid ID { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal PriceBefore17hWeekDay { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal PriceAfter17hWeekDay { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal PriceBefore17hWeekeend { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal PriceAfter17hWeekeend { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal Surcharge3D { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal Surcharge4D { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal SurchargeIMAX { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal SurchargeVIP { get; set; }
        [Precision(18, 3)]
        [Required(ErrorMessage = "Giá vé không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn 0.")]
        public decimal SurchargeCouple { get; set; }
    }
}
