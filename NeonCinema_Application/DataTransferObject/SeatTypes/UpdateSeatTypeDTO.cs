﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.SeatTypes
{
    public class UpdateSeatTypeDTO
    {
        public Guid ID { get; set; }
        public string SeatTypeName { get; set; }
        public decimal Price { get; set; }
    }
}
