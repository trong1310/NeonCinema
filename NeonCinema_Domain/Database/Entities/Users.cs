using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Users : EntityBase
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string Images { get; set; }
        public DateTime? DateOrBriht { get; set; }
        public string Adderss { get; set; }
        public EntityStatus Status { get; set; }
        public Guid RoleID { get; set; }
        //
    
        public virtual Roles? Roles { get; set; }
        public virtual ICollection<Bill>? Bills { get; set; }
        public virtual ICollection<PendingPoint>? PendingPoint { get; set; }
        public virtual ICollection<PromotionUsers>? PromotionUsers { get; set; }
        public virtual ICollection<RankMember>? RankMembers { get; set; }
    }
}
