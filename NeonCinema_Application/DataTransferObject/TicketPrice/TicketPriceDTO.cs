using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.TicketPrice
{
    public class TicketPriceDTO
    {
        public Guid ID { get; set; }
        public Guid ShowTimeID { get; set; }
        public Guid SeatID { get; set; }
        public Guid ScreeningID { get; set; }
        public decimal Price { get; set; }
    }
}
