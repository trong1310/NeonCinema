﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.FoodCombos
{
    public class FoodComboDeleteRequest
    {
        public Guid ID { get; set; }
        public Guid DeleteBy { get; set; }
    }
}
