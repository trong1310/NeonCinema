﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Countrys
    {
        [Key]
        public Guid ID { get; set; }
        public string CountryName { get; set; }
		//
		public virtual ICollection<Movies>? Movies { get; set; }
	}
}
