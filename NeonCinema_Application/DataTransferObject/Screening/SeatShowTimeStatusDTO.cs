using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
	public class SeatShowTimeStatusDTO
	{
		public Guid ID { get; set; }
		public Guid ShowtimeId { get; set; }
		public Guid RoomID { get; set; }
		public Guid SeatID { get; set; }
		public DateTime ShowDate { get; set; }
		public seatEnum seatEnum { get; set; }
	}
}
