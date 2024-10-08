using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Room
{
    public class RoomCreateRequest
    {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public EntityStatus Status { get; set; }
        public Guid CinemasID { get; set; } = Guid.Parse("d288fe9d-79fd-4a83-8443-1a6c17ecdc7d");

    }
}
