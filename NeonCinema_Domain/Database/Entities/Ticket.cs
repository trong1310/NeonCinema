﻿using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
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
		public Guid MovieID { get; set; }
		public Guid SeatID { get; set; }
        public Guid ScreningID { get; set; }
		[Precision(18, 2)]
		public decimal Price { get; set; }
		public ticketEnum Status { get; set; }

		public virtual ICollection<BillTicket>? BillTickets { get; set; }
		public virtual Screening? Screenings { get; set; }
		public virtual Movies? Movies { get; set; }
		public virtual Seat? Seat { get; set; }
	}
}
