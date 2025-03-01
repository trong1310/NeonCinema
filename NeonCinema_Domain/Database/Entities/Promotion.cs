﻿using NeonCinema_Domain.Database.Base;
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
        public string Name { get; set; }
        public string Code { get; set; }  // Tên khuyến mãi
        public string Description { get; set; }  // Mô tả khuyến mãi
        public double? DiscountAmount { get; set; } //giảm theo giá
        public double? DiscountPercentage { get; set; } //giảm theo %
        public double? AmountMax { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PromotionStatus Status { get; set; }
        public virtual ICollection<PromotionUsers>? PromotionUsers { get; set; }
        public virtual ICollection<Bill>? Bills { get; set; }
       
    }
}

