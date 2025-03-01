﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
	public class MailPromotionRequest
	{
		public string FullName { get; set; }
		public string ToEmail {  get; set; }
		public string NamePromotion { get; set; }
		public string Code { get; set; }
		public double? DiscountPercentage { get; set; } // giảm theo %
		public double? DiscountAmount { get; set; } // giảm theo gia

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
