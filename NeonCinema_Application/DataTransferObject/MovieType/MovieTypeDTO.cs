using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieTypes
{
    public class MovieTypeDTO
    {
        public Guid ID { get; set; }
        public string MovieTypeName { get; set; }
    }
}
