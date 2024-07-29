using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Genre : EntityBase
    {
        public Guid GenreID { get; set; }
        public string GenreName { get; set; }
        //
        public virtual ICollection< MovieDetail>? MovieDetails { get; set; }   
    }
}
