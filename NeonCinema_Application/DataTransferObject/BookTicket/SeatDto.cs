using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket
{
	public class SeatDto
	{
		public Guid ID { get; set; }
		public string SeatNumber { get; set; }
		public string SeatType { get; set; }
		public seatEnum Status { get; set; }
		public Decimal? Price { get; set; }
	}
	public class SeatShowTimeDTO
	{
		public Guid ID { get; set; }
		public seatEnum Status { get; set; }
	}
}
