using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Bill : EntityBase
    {
		public Guid ID { get; set; }
		public Guid UserID { get; set; }
		public decimal TotalPrice { get; set; }
		public string QrCode { get; set; }
		public EntityStatus Status { get; set; }
		public virtual Users? Users { get; set; }
		public virtual ICollection<FoodCombo>? FoodCombos { get; set; }
        // Quan hệ với khuyến mãi đã áp dụng
      
    }
}
