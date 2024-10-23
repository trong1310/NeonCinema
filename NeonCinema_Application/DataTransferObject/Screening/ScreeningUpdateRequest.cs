using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ScreeningUpdateRequest
    {
        public Guid ID { get; set; }

        [Required]
        public DateTime ShowDate { get; set; }

        [Required]
        public Guid ShowTimeID { get; set; }

        [Required]
        public Guid MovieID { get; set; }

        [Required]
        public Guid RoomID { get; set; }

        public EntityStatus Status { get; set; }
    }
}
