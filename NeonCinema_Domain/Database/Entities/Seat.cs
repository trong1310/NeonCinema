using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Seat : EntityBase
    {
        public Guid SeatID { get; set; }
        public string SeatNumber { get; set; }
        
        public Guid SeatTypeID { get; set; }
        public Guid RoomID { get; set; }
        ///
        public virtual ICollection<Ticket>? Ticket { get; set; }
        public virtual SeatType? SeatType { get; set; }
        public virtual Room? Room { get; set; }

    }
}
