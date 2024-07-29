using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Rating : EntityBase
    {
        public Guid RatingID { get; set; }
        public int Ratings {  get; set; }
        public string Comment { get; set; }
        public DateTime RatingDate { get; set; }
        public EntityStatus Status { get; set; }
        public Guid TicketID { get; set; }
        public Guid CustomerID { get; set; }

        // 
        public virtual Customers? Customers { get; set; }
        public virtual Ticket? Ticket { get; set; }

    }
}
