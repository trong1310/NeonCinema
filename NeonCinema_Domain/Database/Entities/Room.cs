using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Room : EntityBase
    {
        public Guid RoomID { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }

    }
}
