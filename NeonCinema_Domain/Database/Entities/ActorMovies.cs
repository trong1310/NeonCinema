using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class ActorMovies : EntityBase
    {
        public Guid MovieID { get; set; }
        public virtual Movies? Movie { get; set; }

        public Guid ActorID { get; set; }
        public virtual Actor? Actor { get; set; }

        public bool IsLeadActor { get; set; }

    }
}
