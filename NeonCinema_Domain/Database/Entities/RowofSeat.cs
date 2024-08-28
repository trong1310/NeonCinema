﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class RowofSeat
    {
        public Guid RowofSeatID { get; set; }
        public string RowofSeatName { get; set; }
        public EntityStatus Status { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
