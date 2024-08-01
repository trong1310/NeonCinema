using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieDetail
{
    public class MovieDetailUpdateRequets
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
       // public Guid MovieID { get; set; }
    }
}
