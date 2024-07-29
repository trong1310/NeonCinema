﻿using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Screening : EntityBase
    { 
        public Guid ScreeningID { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime ScreeningDate { get; set; }
    }
}
