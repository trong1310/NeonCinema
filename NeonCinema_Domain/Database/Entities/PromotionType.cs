using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    
    public class PromotionType
    {
        public Guid PromotionTypeID { get; set; }
        public string PromotionName { get; set; }
        public EntityStatus Status { get; set; } 
        
        public virtual ICollection<Promotion>? Promotions { get; set; }
    }
}
