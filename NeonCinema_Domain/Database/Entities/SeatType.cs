using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class SeatType : EntityBase
    {
        public Guid ID { get; set; }
        public string SeatTypeName { get; set; }
        public virtual ICollection<Seat>? Seats { get; set; }
        public virtual ICollection<TicketPrice>? TicketPrice { get; set; }

    }

}
