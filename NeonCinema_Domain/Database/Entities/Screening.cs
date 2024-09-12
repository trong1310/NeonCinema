using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Screening : EntityBase
    { 
        public Guid ID { get; set; }
        public EntityStatus Status { get; set; }
        public Guid ShowTimeID { get; set; }
        public Guid ShowDateID { get; set; }
        public Guid  MovieID { get; set; }
        public Guid  RoomID { get; set; }
   
        //
        public virtual  Movies? Movies { get; set; }
		public virtual Room? Rooms { get; set; }
		public virtual ShowDate? ShowDate { get; set; }
		public virtual ShowTime? ShowTime { get; set; }
		public virtual ICollection<Ticket>? Ticket { get; set; }
	}
}
