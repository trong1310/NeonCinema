using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowTime
{
    public class ShowTimeUpdateRequest
    {
        [Required(ErrorMessage = "Start Time is required.")]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "End Time is required.")]
        public TimeSpan EndTime { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public EntityStatus Status { get; set; }
    }
}
