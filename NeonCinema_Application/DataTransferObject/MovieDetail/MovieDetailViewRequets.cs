using NeonCinema_Application.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieDetail
{
    public class MovieDetailViewRequets : PaginationRequest
    {
        public int? AgeAllowed { get; set; }

        public Guid? ActorID { get; set; }
        public string? DirectorName { get; set; }
        public string? MovieTypeName { get; set; }
        public string? Lenguage { get; set; }
        public string? Genre { get; set; }
    }
}
