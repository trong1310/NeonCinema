using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class MovieDetail : EntityBase
    {
        public Guid MovieDetailID { get; set; }
        public int Duration { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public int AgeAllowed { get; set; }
        public List<string> Images { get; set; }
        public Guid ActorID { get; set; }
        public Guid DirectorID { get; set; }
        public Guid MovieTypeID { get; set; }
        public Guid LenguageID { get; set; }
        public Guid GenreID { get; set; }
        public Guid MovieID { get; set; }

        //
        public virtual Actor? Actor { get; set; }
        public virtual Director? Director { get; set; }
        public virtual MovieType? MovieType { get; set; }
        public virtual Lenguage? Lenguage { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual Movies? Movies { get; set; }

    }
}
