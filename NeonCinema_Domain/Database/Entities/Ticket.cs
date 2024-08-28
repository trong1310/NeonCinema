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
        public Guid TicketID { get; set; }
        public decimal Price { get; set; }
        public string BarCode {  get; set; }
        public EntityStatus Status { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid SeatID { get; set; }
        
       public Guid SurchargesID { get; set; }
        public Guid ShowtimeID { get; set; }


        //
        public virtual Customers? Customers { get; set; }
        public virtual Seat? Seats { get; set; }
       public virtual BookTickets BookTickets { get; set; }
       public virtual Screening Screening { get; set; }
        public virtual ICollection<ShowTime>? ShowTimes { get; set; }
        public virtual ICollection<Surcharges>? Surcharges { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<Rating>? Rating { get; set; }

    }
}
