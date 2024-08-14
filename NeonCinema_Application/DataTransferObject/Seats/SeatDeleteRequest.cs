using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Seats
{
    public class SeatDeleteRequest
    {
        public Guid SeatID { get; set; }
        public Guid DeleteBy { get; set; }
    }
}
