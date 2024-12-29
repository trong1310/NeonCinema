using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Resp
{
	public class BillResp
	{
		public Guid? Id { get; set; }
		public string? BillCode { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CustomerName { get; set; }
		public string? Films { get; set; }
		public string? Email { get; set; }
		public decimal? TotalPrice { get; set; }
		public decimal? AfterPrice { get; set; }

		public string? Voucher { get; set; }
		
		public List<BillComboResp>? BillCombo { get; set; }
		public List<TicketResp>? TicketResp { get; set; }

	}
}
