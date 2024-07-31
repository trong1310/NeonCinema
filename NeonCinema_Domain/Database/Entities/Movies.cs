﻿using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Movies : EntityBase
    {
        public Guid MovieID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public MovieStatus Status { get; set; }
         //
        public virtual ICollection< MovieDetail>? MovieDetails { get; set; }
        public virtual ICollection< Screening>? Screenings { get; set; }
    }
}
