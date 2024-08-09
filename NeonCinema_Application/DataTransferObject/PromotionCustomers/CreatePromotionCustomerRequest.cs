﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.PromotionCustomers
{
    public class CreatePromotionCustomerRequest
    {
        
        public Guid PromotionId { get; set; }
        
        public EntityStatus Status { get; set; }
    }
}
