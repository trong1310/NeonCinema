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
        //Promotion
        [Display(Name = "Không hoạt động")]
        InActive = 1,
        [Display(Name = "Hoạt động")]
        Active = 2,
        [Display(Name = "Đã hết hạn")]
        Expired = 3,

        //Promotion User
        [Display(Name = "Chưa sử dụng")]
        Unused = 5,
        [Display(Name = "Đã sử dụng")]
        Used = 6,
    }
}
