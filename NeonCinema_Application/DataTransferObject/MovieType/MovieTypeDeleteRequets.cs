﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.MovieType
{
    
    public class MovieTypeDeleteRequets
    {
        public Guid MovieTypeID { get; set; }
        public Guid? DeletedBy {  get; set; }
    }
}
