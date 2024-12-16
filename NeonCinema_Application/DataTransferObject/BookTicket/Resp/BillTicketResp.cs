using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Resp
{
	public class BillTicketResp
	{
		public Guid BillTicketID { get; set; }
		public string? SeatNumber { get; set; }
	}
}
