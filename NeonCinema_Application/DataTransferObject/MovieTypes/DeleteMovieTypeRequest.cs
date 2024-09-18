using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieTypes
{
    public class DeleteMovieTypeRequest
    {
        public Guid ID { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
