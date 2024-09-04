using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class RankMember :  EntityBase
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public string Rank { get; set; }
        public int MinPoint { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime StarDate { get; set; }
        //
        public virtual Users? Users { get; set; }
    }
}
