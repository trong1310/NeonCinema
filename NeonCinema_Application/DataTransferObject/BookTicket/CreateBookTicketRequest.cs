using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket
{
    public class CreateBookTicketRequest 
    {
		public Guid RoomID { get; set; }
		public Guid TicketPriceID { get; set; }
		public Guid SeatID { get; set; }
		public Guid ScreningID { get; set; }
		public Guid? CustomerID { get; set; }
        public List<Guid>? FoodComboId { get; set; }
        public int QuantityCombo { get; set; }
    }
}
