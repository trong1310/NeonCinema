using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Actor : EntityBase
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string? Biography { get; set; }
        public string Images { get; set; }
        
        public EntityStatus Status { get; set; }


        //
        public virtual ICollection<ActorMovie>? ActorMovies { get; set; }

    }
}
