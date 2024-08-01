using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Movie
{
    public class MovieCreateRequets
    {
       // public Guid MovieID { get; set; }
        public string? MovieName { get; set; }
        public string? Description { get; set; }
        public MovieStatus Status { get; set; }
    }
}
