using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Actors
{
    public class ViewActorRequest : PaginationRequest
    {
        public string? SearchName { get; set; }
    }
}
