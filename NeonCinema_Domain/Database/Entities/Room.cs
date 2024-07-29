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
        public Guid CenimaID { get; set; }

        // 
        public virtual ICollection<Screening>? Screenings { get; set; }
        public virtual ICollection<Seat>? Seats { get; set; }
        //
        public virtual Cenima? Cenima { get; set; }
    }
}
