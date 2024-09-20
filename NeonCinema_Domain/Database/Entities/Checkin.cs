using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class Checkin : EntityBase
	{
		public Guid ID { get; set; }
		public string Code { get; set; }
		public string Type { get; set; }
		public string Name { get; set; }	
		public Guid TicketID { get; set; }

		public virtual Ticket? Tickets { get; set; }
	}
}
