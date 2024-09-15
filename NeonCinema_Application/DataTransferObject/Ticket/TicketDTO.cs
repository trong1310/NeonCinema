using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Ticket
{
    public class TicketDTO
    {
        public Guid CustomerID { get; set; }
        public Guid SeatID { get; set; }
        public Guid ScreeningID { get; set; }
        public Guid SurchargeID { get; set; }
        public decimal Price { get; set; }
        public string QrCode { get; set; }
    }
}
