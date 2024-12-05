using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookingHistory
{
	public class BookingHistoryDTO
	{
		public Guid TicketID { get; set; }
		public string UserName { get; set; }
		public string MovieName { get; set; }
		public DateTime ShowDate { get; set; }
		public TimeSpan StartTime { get; set; }
		public string SeatNumber { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
		public string MoviePoster { get; set; }
	}
}
