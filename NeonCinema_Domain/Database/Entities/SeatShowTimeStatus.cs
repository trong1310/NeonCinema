using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class SeatShowTimeStatus : EntityBase
	{
		[Key]
		public Guid ID { get; set; }
		public Guid ShowtimeId { get; set; }
		public Guid RoomID { get; set; }
		public Guid SeatID { get; set; }
		public seatEnum seatEnum { get; set; }
		public virtual ShowTime? ShowTime { get; set; }
		public virtual Room? Room { get; set; }
		public Seat? Seat {  get; set; } 
	}
}
