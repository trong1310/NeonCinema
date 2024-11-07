using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace NeonCinema_Infrastructure.Database.Configuration
    {
        public class BookTickets
        {
      
            public Guid ID { get; set; }
            public Guid CustomerID { get; set; }
            public Guid TicketID { get; set; }
        public EntityStatus Status { get; set; }

        public virtual Users? Customers { get; set; }
        public virtual Ticket? Tickets { get; set; }
    }
}
