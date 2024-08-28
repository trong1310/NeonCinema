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
        [Key]
        public Guid BookTicketId { get; set; }
        public Guid CustomerID { get; set; }
        public Guid TicketID { get; set; }
        public EntityStatus Status { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
