using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class ShowTime
    {
        public Guid ID { get; set; }
        public TimeSpan StartTime { get; set; }  
        public TimeSpan EndTime { get; set; }
        public EntityStatus Status { get; set; }
        public virtual ICollection<Screening>? Screening { get; set; }
        public virtual ICollection<TicketPrice>? TicketPrices { get; set; }
		public virtual ICollection<SeatShowTimeStatus>? SeatShowTimeStatus { get; set; }
	}
}
