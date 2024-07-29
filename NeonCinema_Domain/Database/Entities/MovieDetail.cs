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
    }
}
