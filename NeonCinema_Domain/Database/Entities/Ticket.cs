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
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid SeatID { get; set; }
        public Guid ScreeningID { get; set; }
        public Guid SurchargeID { get; set; }
        public decimal Price { get; set; }
        public string QrCode { get; set; }
        public virtual  ICollection<BookTickets>? BookTickets { get; set; }
		public virtual Users? Customers { get; set; }
        public virtual Seat? Seat { get; set; }
        public virtual ICollection<Checkin>? Checkins { get; set; }
        public virtual ICollection<TicketSeat>? TicketSeats { get; set; }
        public virtual Screening? Screening { get; set; }
        public virtual Surcharges? Surcharges { get; set; }

    }
}
