using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieDetail
{
    public class MovieDetailDeleteRequets
    {
        public Guid MovieDetailID { get; set; }
        public Guid? DeletedBy {  get; set; }
    }
}
