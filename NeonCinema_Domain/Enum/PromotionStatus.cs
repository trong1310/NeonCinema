using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Enum
{
	public enum PromotionStatus
	{
		[Display(Name = "Riêng tư")]
		Private = 1,
		[Display(Name = "Công khai")]
		Public = 2,
		[Display(Name = "Đã hết hạn")]
		Expired = 3,
		[Display(Name = "Đã áp dụng")]
		Applied = 4,

		//
		[Display(Name = "Chưa sử dụng")]
		Unused = 5,
		[Display(Name = "Đã sử dụng")]
		Used = 6,
	}
}
