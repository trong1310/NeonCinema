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
		public long BillCode { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CustomerName { get; set; }
		public string? Films { get; set; }
		public string? FilmsType { get; set; }
		public string? Email { get; set; }
		public decimal? TotalPrice { get; set; }
		public decimal? AfterPrice { get; set; }
		public string? CreatedBy { get; set; }
		public decimal? Voucher { get; set; }
		public decimal? Surcharge { get; set; }
		
		public List<BillComboResp>? BillCombo { get; set; }
		public List<TicketResp>? TicketResp { get; set; }

	}
}
