using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.SeatTypes
{
    public class SeatTypeDeleteRequest
    {
        public Guid SeatTypeID { get; set; }
        public Guid DeleteBy { get; set; }
    }
}
