using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Seats
{
    public class CreateSeatDTO
    {
        public string SeatNumber { get; set; }
        public string Column { get; set; }
        public string Row { get; set; }
        public seatEnum Status { get; set; }
        public Guid RoomID { get; set; }
        public Guid SeatTypeID { get; set; }
    }
}
