using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class ServiceOder
    {
        public Guid ServiceOderID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ServiceID { get; set; }

        ///
        public virtual ICollection<BillDetail>? BillDetail { get; set; }
        public virtual Service? Service { get; set; }
    }
}
