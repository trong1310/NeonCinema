using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Room
{
    public class RoomDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public EntityStatus Status { get; set; }
        public Guid SeatID { get; set; }


    }
}
