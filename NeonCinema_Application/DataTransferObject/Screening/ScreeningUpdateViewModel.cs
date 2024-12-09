using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ScreeningUpdateViewModel
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Show date is required")]
        public DateTime ShowDate { get; set; }

        [Required(ErrorMessage = "Show time is required")]
        public Guid ShowTimeID { get; set; }

        [Required(ErrorMessage = "Movie is required")]
        public Guid MovieID { get; set; }

        [Required(ErrorMessage = "Room is required")]
        public Guid RoomID { get; set; }

        public ScreeningStatus Status { get; set; }
    }
}
