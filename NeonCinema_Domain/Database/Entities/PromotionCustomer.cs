using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PromotionCustomer :  EntityBase
    {
        public Guid Id { get; set; }
        public Guid CustomerID { get; set; }
        public EntityStatus Status { get; set; }
    }
}
