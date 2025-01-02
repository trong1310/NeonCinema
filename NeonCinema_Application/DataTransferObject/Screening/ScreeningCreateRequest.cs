using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ScreeningCreateRequest
    {
        public ScreeningStatus Status { get; set; }
        public Guid ShowTimeID { get; set; }
        public DateTime ShowDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Chưa chọn phim")]
        public Guid MovieID { get; set; }

		[Required(ErrorMessage = "Chưa chọn phòng")]
		public Guid RoomID { get; set; }
    }
}
