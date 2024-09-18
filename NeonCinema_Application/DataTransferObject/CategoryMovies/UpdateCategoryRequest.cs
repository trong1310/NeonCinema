using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.CategoryMovies
{
    public class UpdateCategoryRequest
    {
        public Guid ID { get; set; }
        public Guid MovieID { get; set; }
        public Guid MovieTypeID { get; set; }
        public EntityStatus Status { get; set; }
    }
}
