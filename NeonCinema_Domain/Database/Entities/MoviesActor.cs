using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
     public class MoviesActor
    {
        public Guid MovieID { get; set; }
        public virtual Movies Movie { get; set; }

        public Guid ActorID { get; set; }
        public virtual Actor Actor { get; set; }

        // Thuộc tính xác định vai trò (chính/phụ)
        public bool IsLeadActor { get; set; }

    }
}
