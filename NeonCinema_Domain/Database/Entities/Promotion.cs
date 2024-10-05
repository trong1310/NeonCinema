using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Promotion : EntityBase
    {
        public Guid ID { get; set; }  // Khóa chính
        public string code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi
        public double Amount { get; set; } // giảm theo %
        public EntityStatus Status { get; set; }
        public virtual ICollection<PromotionUsers>? PromotionUsers { get; set; }
       
    }
}

