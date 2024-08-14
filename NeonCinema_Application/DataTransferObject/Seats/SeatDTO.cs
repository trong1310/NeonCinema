using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Seats
{
    public class SeatDTO
    {
        public string SeatNumber { get; set; }

        public Guid SeatTypeID { get; set; }
        public Guid RoomID { get; set; }
    }
}
