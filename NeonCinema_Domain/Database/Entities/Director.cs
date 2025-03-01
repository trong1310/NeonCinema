﻿using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Director :  EntityBase
    {
		public Guid ID { get; set; }
		public string FullName { get; set; }
		public EntityStatus Gender { get; set; }
		public string Address { get; set; }
		public string Nationality { get; set; }
		public string? Biography { get; set; }
		public EntityStatus Status { get; set; }
		public virtual ICollection<Movies>? Movies { get; set; }
    }
}
