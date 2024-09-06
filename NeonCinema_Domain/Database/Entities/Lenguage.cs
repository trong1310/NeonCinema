﻿using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Lenguage : EntityBase
    {
        public Guid ID { get; set; }
        public string LenguageName { get; set; }
       
        //
        public virtual ICollection<Movies>? Movies { get; set; }
    }
}
