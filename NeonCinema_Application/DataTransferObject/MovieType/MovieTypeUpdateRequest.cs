using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieType
{
    public class MovieTypeUpdateRequest
    {
        public Guid MovieTypeID { get; set; }
        public string MovieTypeName { get; set; }
    }
}
