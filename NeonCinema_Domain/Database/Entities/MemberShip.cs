using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class MemberShip :  EntityBase
    {
        public Guid MemberShipID { get; set; }
        public string Rank { get; set; }
        public string Endow { get; set; }
        public Guid CustomerID { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime StarDate { get; set; }
        //
        public virtual Customers? Customers { get; set; }
    }
}
