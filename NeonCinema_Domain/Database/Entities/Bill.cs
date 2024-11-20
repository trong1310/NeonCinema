using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Bill : EntityBase
    {
		public Guid ID { get; set; }
		public Guid? UserID { get; set; }
		[Precision(18, 2)]
		public decimal TotalPrice { get; set; }
		public string BillCode { get; set; }
		public ticketEnum Status { get; set; }
		public virtual Users? Users { get; set; }
		public virtual ICollection<BillCombo> BillCombos { get; set; }
		public virtual ICollection<BillTicket>? BillTickets { get; set; }
		 
      
    }
}
