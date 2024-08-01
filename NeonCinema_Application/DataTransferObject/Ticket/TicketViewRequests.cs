using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Ticket
{
    public interface TicketViewRequests
    {
        public decimal Price { get; set; }
        public string BarCode { get; set; }
        public string SeatNumber { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime ScreeningDate { get; set; }
        public string RoomName { get; set; }


    }
}
