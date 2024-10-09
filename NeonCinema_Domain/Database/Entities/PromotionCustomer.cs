using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PromotionUsers
    {
        public Guid ID { get; set; }  // Khóa chính
        public Guid PromotionID { get; set; }  // Khóa ngoại đến Promotion
        public Guid UserID { get; set; }  // Khóa ngoại đến user
        public bool IsUsed { get; set; }  // Khách hàng đã sử dụng khuyến mãi chưa

        // Liên kết
        public virtual Promotion? Promotion { get; set; }
        public virtual Users? User { get; set; }
    }
}
