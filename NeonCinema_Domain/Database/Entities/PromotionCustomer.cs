﻿using NeonCinema_Domain.Database.Base;
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
        public Guid PromotionId { get; set; }
        public Guid ID { get; set; }
        public EntityStatus Status { get; set; }
        //
        public virtual Promotion? Promotion { get; set; }
        public virtual Customers? Customers { get; set; }
    }
}
