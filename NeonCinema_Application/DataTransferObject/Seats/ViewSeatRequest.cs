using NeonCinema_Application.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.SeatTypes
{
    public class ViewSeatRequest: PaginationRequest
    {
        public string? search { get; set; }
    }
}
