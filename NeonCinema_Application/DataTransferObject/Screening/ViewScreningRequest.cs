using NeonCinema_Application.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ViewScreningRequest : PaginationRequest
    {
        public DateTime? SearchDate { get; set; }
    }
}
