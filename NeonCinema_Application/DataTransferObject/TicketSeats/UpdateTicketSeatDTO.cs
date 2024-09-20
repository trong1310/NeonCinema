using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.TicketSeats
{
    public class UpdateTicketSeatDTO
    {
        public Guid ID { get; set; }
        public Guid CinemasID { get; set; }
        public Guid RoomID { get; set; }
        public Guid TicketID { get; set; }
        public Guid MovieID { get; set; }
        public Guid SeatID { get; set; }
        public Guid Show_ReleaseID { get; set; }
        public Guid SeatShowTimeStatusID { get; set; }
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
    }
}
