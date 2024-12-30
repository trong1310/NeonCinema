using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Resp
{
	public class TicketResp
	{
		public Guid TicketID { get; set; }
		public string? SeatNumber { get; set; }
		public string? ShowTime { get; set; }
		public decimal? Prices { get; set; }
	}
}
