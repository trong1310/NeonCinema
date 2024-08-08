using NeonCinema_Application.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieType
{
    public class MovieTypeViewRequets : PaginationRequest
    {
        public string? SearchName { get; set; }
    }
}
