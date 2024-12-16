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
		public decimal? TotalPrice { get; set; }
		public List<BillComboResp>? BillCombo { get; set; }
		public List<BillTicketResp>? BillTickets { get; set; }

	}
}
