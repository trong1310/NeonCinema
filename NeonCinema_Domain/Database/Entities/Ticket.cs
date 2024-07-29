using NeonCinema_Domain.Database.Base;
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
        public int Quantity { get; set; }

    }
}
