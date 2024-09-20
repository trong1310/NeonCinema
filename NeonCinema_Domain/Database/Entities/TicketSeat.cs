using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class TicketSeat : EntityBase
	{
		public Guid  ID { get; set; }
		public Guid CinemasID { get; set; }
		public Guid RoomID { get; set; }
		public Guid TicketID { get; set; }
		public Guid MovieID { get; set; }
		public Guid SeatID { get; set; }
		public Guid Show_ReleaseID { get; set; }
		public Guid SeatShowTimeStatusID { get; set; }
		public decimal Price { get; set; }
		public EntityStatus Status { get; set; }

		public virtual Cinemas? Cinemas { get; set; }
		public virtual Room? Room { get; set; }
		public virtual Ticket? Tickets { get; set; }
		public virtual Movies? Movies { get; set; }
		public virtual Seat? Seat { get; set; }
		public virtual Show_release? Show_Release { get; set; }
		public virtual Seat_ShowTime_Status? Seat_Show_TimeStatus { get; set;}

	}
}
