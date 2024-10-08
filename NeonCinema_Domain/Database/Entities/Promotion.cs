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
        public string Name { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi
        public decimal DiscountAmount { get; set; }  // Số tiền giảm giá (có thể % hoặc số tiền cụ thể)
                                                     // Khóa ngoại
        public Guid PromotionTypeID { get; set; }  // Loại khuyến mãi 
        public DateTime StartDate { get; set; }  // Ngày bắt đầu khuyến mãi
        public DateTime EndDate { get; set; }  // Ngày kết thúc khuyến mãi
        public bool IsActive { get; set; }  // Trạng thái hoạt động
        public Guid? UserID { get; set; }  // Khách hàng cụ thể (dùng chung với bảng Users)
        public Guid? PromotionCodeID { get; set; }  // Mã khuyến mãi (nếu có)

        // Liên kết
        public virtual ICollection<BillPromotion>? BillPromotions { get; set; }
        public virtual PromotionType? PromotionType { get; set; }
        public virtual ICollection<PromotionMovie>? PromotionMovies { get; set; }  // Nhiều khách hàng có thể được áp dụng khuyến mãi này
        public virtual ICollection<PromotionUsers>? PromotionUsers { get; set; }  // Nhiều khách hàng có thể được áp dụng khuyến mãi này
        public virtual PromotionCode? PromotionCode { get; set; }  // Khuyến mãi có thể có mã khuyến mãi
       
    }
}

