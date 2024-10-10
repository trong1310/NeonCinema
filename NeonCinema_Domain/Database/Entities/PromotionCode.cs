using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PromotionCode
    {
        public Guid ID { get; set; }  // Khóa chính
        public string Code { get; set; }  // Mã khuyến mãi
        public DateTime StartDate { get; set; }  // Ngày bắt đầu
        public DateTime EndDate { get; set; }  // Ngày kết thúc
        public int MaxUsage { get; set; }  // Số lần sử dụng tối đa

        // Liên kết
        public virtual ICollection<Promotion>? Promotions { get; set; }  // Mã khuyến mãi liên kết với các khuyến mãi
    }
}
