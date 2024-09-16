using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.SeatShowTimeStatus
{
    public class CreateSeatShowTimeStatusDTO
    {
        public Guid SeatID { get; set; }
        public DateTime ShowTime { get; set; }
        public EntityStatus Status { get; set; }
    }
}
