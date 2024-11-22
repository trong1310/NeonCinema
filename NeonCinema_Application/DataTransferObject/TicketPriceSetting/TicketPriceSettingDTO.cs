using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.TicketPriceSetting
{
	public class TicketPriceSettingDTO
	{
		public Guid ID { get; set; }
		public decimal PriceBefore17hWeekDay { get; set; }
		public decimal PriceAfter17hWeekDay { get; set; }
		public decimal PriceBefore17hWeekeend { get; set; }
		public decimal PriceAfter17hWeekeend { get; set; }
		public decimal Surcharge3D { get; set; }
		public decimal Surcharge4D { get; set; }
		public decimal SurchargeIMAX { get; set; }
		public decimal SurchargeVIP { get; set; }
		public decimal SurchargeCouple { get; set; }
	}
}
