﻿using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Seat : EntityBase
    {
        public Guid ID { get; set; }
        public string SeatNumber { get; set; }
        public string Column {  get; set; }
        public string Row { get; set; } 
        public seatEnum Status { get; set; }
        public Guid SeatTypeID { get; set; }
        public Guid RoomID { get; set; }
		//	public virtual ICollection<TicketPrice>? TicketPrice { get; set; }
		public virtual ICollection<SeatShowTimeStatus>? SeatShowTimeStatus { get; set; }
		public virtual ICollection<Ticket>? Ticket { get; set; }
		public virtual SeatType? SeatTypes { get; set; }
        public virtual Room? Rooms { get; set; }

    }
}
