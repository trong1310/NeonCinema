﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Genre
{
    public class CreateGenreRequest
    {
        public Guid ID { get; set; }
        public string GenreName { get; set; }
    }
}
