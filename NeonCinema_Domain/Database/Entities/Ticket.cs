using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class Ticket : EntityBase
	{
		public Guid  ID { get; set; }
		public Guid CinemasID { get; set; }
		public Guid RoomID { get; set; }
		public Guid TicketPriceID { get; set; }
		public Guid MovieID { get; set; }
		public Guid SeatID { get; set; }
        public Guid ScreningID { get; set; }
        public Guid Show_ReleaseID { get; set; }
		public Guid SeatShowTimeStatusID { get; set; }
		public decimal Price { get; set; }
		public EntityStatus Status { get; set; }

		public virtual Cinemas? Cinemas { get; set; }
		public virtual Room? Room { get; set; }
		public virtual TicketPrice? TicketPrices { get; set; }
		public virtual ICollection<BookTickets>? BookTickets { get; set; }
		public virtual ICollection<BillTicket>? BillTickets { get; set; }
		public virtual Screening? Screenings { get; set; }
		public virtual Movies? Movies { get; set; }
		public virtual Seat? Seat { get; set; }
		public virtual Show_release? Show_Release { get; set; }
		public virtual Seat_ShowTime_Status? Seat_Show_TimeStatus { get; set;}

	}
}
