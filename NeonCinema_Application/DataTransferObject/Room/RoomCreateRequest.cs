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
        public Guid CinemasID { get; set; } = Guid.Parse("6cf8d373-0533-484c-bcc3-63801334fff6"); // Giá trị mặc định

    }
}
