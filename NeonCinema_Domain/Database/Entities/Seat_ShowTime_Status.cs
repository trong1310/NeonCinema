using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class Seat_ShowTime_Status : EntityBase
	{
		public Guid ID { get; set; }
		public Guid SeatID { get; set; }
		public DateTime ShowTime { get; set; }
		public EntityStatus Status { get; set; }
		public virtual Seat? Seat { get; set; }
		public virtual ICollection<Ticket>? TicketSeats { get; set; }
	}
}
