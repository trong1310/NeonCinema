﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Bills
{
    public class BillUpdateRequest
    {
        public Guid ID { get; set; }
        public Guid CheckinID { get; set; }
        public Guid UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public string QrCode { get; set; }
        public EntityStatus Status { get; set; }
    }
}
