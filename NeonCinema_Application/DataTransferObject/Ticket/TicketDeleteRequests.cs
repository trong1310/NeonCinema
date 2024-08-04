using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Ticket
{
    public class TicketDeleteRequests
    {
        public Guid MovieID { get; set; }
        public Guid DeletedBy { get; set; }
    }
}
