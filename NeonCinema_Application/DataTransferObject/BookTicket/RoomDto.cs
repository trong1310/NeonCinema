using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket
{
	public class RoomDto
	{
		public Guid ID { get; set; }
		public string RoomName { get; set; }
		public List<SeatDto> SeatList { get; set; }
	}
}
