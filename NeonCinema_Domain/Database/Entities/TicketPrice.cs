using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class TicketPrice : EntityBase
    {
        public Guid ID { get; set; }
        public Guid ShowTimeID { get; set; }
        public Guid SeatTypeID { get; set; }
        public Guid ScreeningID { get; set; }
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
		public virtual ShowTime? ShowTimes { get; set; }
        public virtual SeatType? SeatTypes { get; set; }
        public virtual ICollection<Ticket>? Ticket { get; set; }
        public virtual Screening? Screening { get; set; }

    }
}
