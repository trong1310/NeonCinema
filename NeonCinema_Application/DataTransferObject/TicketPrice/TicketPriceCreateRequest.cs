using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.TicketPrice
{
    public class TicketPriceCreateRequest
    {
        public Guid ID { get; set; }
        public Guid ShowTimeID { get; set; }
        public Guid SeatTypeID { get; set; }
        public Guid ScreeningID { get; set; }
        public decimal Price { get; set; }
    }
}
