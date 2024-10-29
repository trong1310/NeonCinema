using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PromotionUsers : EntityBase
    {
        public Guid PromotionID { get; set; }  // Khóa ngoại đến Promotion
        public Guid UserID { get; set; }  // Khóa ngoại đến user
        public PromotionStatus Status { get; set; }

        // Liên kết
        public virtual Promotion? Promotion { get; set; }
        public virtual Users? User { get; set; }
    }
}
