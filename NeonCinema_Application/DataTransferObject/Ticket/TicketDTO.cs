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
        public Guid TicketID { get; set; }
        public decimal Price { get; set; }
        public string BarCode { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid SeatID { get; set; }
        public Guid ScreeningID { get; set; }
    }
}
