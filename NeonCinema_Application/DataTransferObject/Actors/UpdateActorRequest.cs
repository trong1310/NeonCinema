﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Actors
{
    public class UpdateActorRequest
    {

        public Guid ID { get; set; }
        public string FullName { get; set; }
       

        public EntityStatus Status { get; set; }
    }
}
