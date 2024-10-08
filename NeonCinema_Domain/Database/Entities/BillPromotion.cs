using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class BillPromotion
    {
        public Guid BillPromotionID { get; set; }

        // Foreign Key tới bảng Bill
        public Guid BillID { get; set; }
        public virtual Bill? Bill { get; set; }

        // Foreign Key tới bảng Promotion
        public Guid PromotionID { get; set; }
        public virtual Promotion? Promotion { get; set; }

        // Số tiền giảm giá
        public decimal DiscountAmount { get; set; }

        // Ngày áp dụng
        public DateTime AppliedDate { get; set; } = DateTime.Now;
    }
}
