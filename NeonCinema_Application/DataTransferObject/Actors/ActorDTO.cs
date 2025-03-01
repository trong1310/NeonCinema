﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Actors
{
    public class ActorDTO
    {
        public Guid ID { get; set; }    
        public string FullName { get; set; }

        public bool IsChecked { get; set; } = false;
		public EntityStatus Status { get; set; }
    }
}
