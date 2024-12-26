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
		public Guid? PromotionID { get; set; }
		public decimal TotalPrice { get; set; }
		[Precision(18, 3)]
		public decimal? AfterDiscount { get; set; }
		[Precision(18, 3)]
		public decimal? Surcharge { get; set; }
		public double? TotalPoint { get; set; }

		public string BillCode { get; set; }
		public ticketEnum Status { get; set; }
		public virtual Users? Users { get; set; }
		public virtual Promotion? Promotions { get; set; }
		public virtual ICollection<BillCombo> BillCombos { get; set; }
		public virtual ICollection<Ticket>? Ticket { get; set; }
		public virtual PendingPoint? PendingPoint { get; set; }


	}
}
