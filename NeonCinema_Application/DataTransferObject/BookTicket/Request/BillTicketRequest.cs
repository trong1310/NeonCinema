using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket.Request
{
	public class BillTicketRequest
	{
		public Guid SeatID { get; set; }
		public decimal Price { get; set; }
	}
}
