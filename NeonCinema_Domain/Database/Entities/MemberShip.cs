using NeonCinema_Domain.Database.Base;
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
        public string Benefits { get; set; }
    }
}
