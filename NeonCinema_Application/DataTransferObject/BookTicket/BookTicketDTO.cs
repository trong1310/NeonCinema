using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket
{
    public class BookTicketDTO
    {
        public Guid CustomerID { get; set; }
        public Guid TicketID { get; set; }
        public EntityStatus Status { get; set; }
    }
}
