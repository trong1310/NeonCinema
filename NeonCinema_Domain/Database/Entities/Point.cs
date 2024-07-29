using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Point : EntityBase
    {
        public Guid PointID { get; set; }
        public int TotalPoint   { get; set; }
        public DateTime DateEarned { get; set; }
        public Guid CustomerID { get; set; }

        //
        public virtual Customers? Customers { get; set; }


    }
}
