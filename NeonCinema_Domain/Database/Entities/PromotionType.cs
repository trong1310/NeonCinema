using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PromotionType
    {
        public Guid ID { get; set; }  // Khóa chính
        public string Name { get; set; }  // Tên loại khuyến mãi (e.g., "Giảm giá phần trăm", "Giảm giá số tiền", etc.)
        public string Description { get; set; }
        // Liên kết
        public virtual ICollection<Promotion>? Promotions { get; set; }  // Khuyến mãi thuộc loại này
    }
}
