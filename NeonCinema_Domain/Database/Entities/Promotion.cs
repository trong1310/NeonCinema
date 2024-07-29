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
        public Guid PromotionID { get; set; }
        public string PromotionCode { get; set; }
        public string Description { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public string proviso { get; set; }
        public string Discount { get; set; }
        public EntityStatus Status { get; set; }
        public Guid PromotionTypeID { get; set; }
        //
        public virtual ICollection<BillDetail>? BillDetail { get; set; }
        public virtual ICollection<PromotionCustomer>? PromotionCustomers { get; set; }
        public virtual PromotionType? PromotionType { get; set; }


    }
}
