using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Movies : EntityBase
    {
        public Guid ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StarTime { get; set; }
        public string Trailer { get; set; }
        public int AgeAllowed { get; set; }
        public MovieStatus Status { get; set; } = MovieStatus.Active;
        public Guid GenreID { get; set; }
        public Guid LenguageID { get; set; }
        public Guid CountryID { get; set; }
        public Guid DirectorID { get; set; }
       
        //
        public virtual ICollection<Screening>? Screening { get; set; }
		public virtual ICollection<TicketSeat>? TicketSeats { get; set; }

		public virtual ICollection<Show_release>? Show_Releases { get; set; }
        public virtual ICollection<ActorMovie>? ActorMovies { get; set; }
        public virtual Director? Director { get; set; }
        public virtual ICollection<CategoryMovies>? CategoryMovies { get; set; }
        public virtual Language? Lenguage { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual Countrys? Countrys { get; set; }
       
        //
    }
}
