using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Pagination
{
    public class PaginationResponse<TDataType>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 15;
        public bool HasNext { get; set; }
        public ICollection<TDataType>? Data { get; set; }
    }
}
