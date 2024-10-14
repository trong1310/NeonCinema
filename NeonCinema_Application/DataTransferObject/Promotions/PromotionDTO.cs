using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
    public class PromotionDTO
    {
        public Guid ID { get; set; }  // Khóa chính
        public string code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi
        public double Amount { get; set; } // giảm theo %
        public DateTime TimeStar { get; set; }
        public DateTime TimeEnd { get; set; }
        public PromotionStatus Status { get; set; }
    }
}
