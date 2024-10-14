using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Promotion
    {
        public Guid ID { get; set; }  // Khóa chính
        public string Code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi
        public decimal DiscountAmount { get; set; }  // Số tiền giảm giá (có thể % hoặc số tiền cụ thể)
                                                  
        public DateTime StartDate { get; set; }  // Ngày bắt đầu khuyến mãi
        public DateTime EndDate { get; set; }  // Ngày kết thúc khuyến mãi
        public EntityStatus Status { get; set; }  // Trạng thái hoạt động
        // Liên kết
     
        public virtual ICollection<PromotionUsers>? PromotionUsers { get; set; }  // Nhiều khách hàng có thể được áp dụng khuyến mãi này

       
    }
}

