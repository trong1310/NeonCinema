﻿using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class ShowTime
    {
        public Guid ShowTimeID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EntityStatus Status { get; set; }

        public virtual Screening Screening { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
