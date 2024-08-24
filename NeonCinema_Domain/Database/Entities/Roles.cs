﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Roles
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public EntityStatus Status { get; set; }

        public virtual Employees Employees { get; set; }

    }
}
