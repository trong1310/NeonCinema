using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeonCinema_Application.Pagination;

namespace NeonCinema_Application.DataTransferObject.Ticket
{
    public class TicketViewRequests : PaginationRequest
    {
        public Guid TicketID { get; set; }
    }
}
