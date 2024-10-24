using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class Show_release : EntityBase
	{
		public Guid ID { get; set; }
		public Guid MovieID { get; set; }
		public Guid RoomID { get; set; }
		public EntityStatus Status { get; set; }
		public DateTime TimeRelease { get; set; }
		public DateTime DateRelease { get; set; }
		public virtual Movies? Movies { get; set; }
		public virtual Room? Room { get; set; }
		public virtual ICollection<Ticket>? TicketSeats { get; set; }
	}
}
