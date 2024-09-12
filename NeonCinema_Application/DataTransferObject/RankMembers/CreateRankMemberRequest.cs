﻿using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.RankMembers
{
    public class CreateRankMemberRequest
    {
        public Guid UserID { get; set; }
        public string Rank { get; set; }
        public int MinPoint { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime StartDate { get; set; }
    }
}
