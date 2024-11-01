using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Seats
{
    public class SeatDTO
    {
        public Guid ID { get; set; }
        public string SeatNumber { get; set; }
        public string Column { get; set; }
        public string Row { get; set; }
        public EntityStatus Status { get; set; }
        
        public Guid SeatTypeID { get; set; }
       
        public string SeatTypeName { get; set; }  // Tên loại ghế
    }
}
