using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Resp
{
	public class BillTicketResp
	{
		public string? SeatNumber { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
	}
}
