﻿using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class MovieType : EntityBase
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Tên kiểu phim không được để trống.")]
        public string MovieTypeName { get; set; }
        
        public virtual ICollection<Movies>? Movies { get; set; }
    }
}
