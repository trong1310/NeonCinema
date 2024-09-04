using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PaymentMethod : EntityBase
    {
        public Guid ID { get; set; }
        public string Name  { get; set; }
        public string? QRCode { get; set; }
        public EntityStatus Status { get; set; }
        ///
        public virtual ICollection<Bill> BillDetail { get; set; }
    }
}
