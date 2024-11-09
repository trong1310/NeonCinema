using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Room : EntityBase
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public EntityStatus Status { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Guid CinemasId { get; set; }
        public virtual Cinemas? Cinemas { get; set; }
        public virtual ICollection<Screening>? Screenings { get; set; }
		public virtual ICollection<Ticket>? TicketSeats { get; set; }
		public virtual ICollection<Seat>? Seats { get; set; }
		public virtual ICollection<Show_release>? Show_Releases { get; set; }
    }
}
