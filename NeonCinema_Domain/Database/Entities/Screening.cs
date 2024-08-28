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
        public Guid ScreeningID { get; set; }
        public Guid ShowTimeID { get; set; }
      
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime ScreeningDate { get; set; }
        public Guid MovieDetailsID { get; set; }
        public Guid RoomID { get; set; }
        //
         public virtual ICollection<ShowTime> ShowTimes { get; set; }    
         public virtual ICollection<Ticket> Tickets{ get; set; }    
        //
        public virtual MovieDetail? MoviesDetails { get; set; }
        public virtual Room? Room {  get; set; } 
    }
}
