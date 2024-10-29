using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
	public class PromotionUserDTO
	{
		public Guid PromotionID { get; set; }  // Khóa ngoại đến Promotion
		public Guid UserID { get; set; }  // Khóa ngoại đến user
	}
}
