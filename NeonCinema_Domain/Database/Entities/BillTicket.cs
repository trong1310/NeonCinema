using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class BillTicket : EntityBase
	{
		public Guid BillId { get; set; }
		public Guid TicketId { get; set; }
		public virtual Bill? Bills { get; set; }
		public virtual Ticket? Tickets { get; set; }
	}
}
