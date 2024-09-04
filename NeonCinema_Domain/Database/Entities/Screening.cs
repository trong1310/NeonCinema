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
      
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime ScreeningDate { get; set; }
        public Guid  MovieID { get; set; }
        public Guid  RoomID { get; set; }

        //
         public virtual ICollection<ShowTime>? ShowTimes { get; set; }     
         public virtual ICollection<ShowDate>? ShowDates { get; set; }     
        //
        public virtual  Movies? Movies { get; set; }
		public virtual Room? Rooms { get; set; }
		public virtual ICollection<Ticket>? Ticket { get; set; }
	}
}
