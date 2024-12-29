using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ScreeningDTO
    {
        public Guid ID { get; set; }
        public TimeSpan? ShowTime { get; set; }  
        public DateTime? ShowDate { get; set; }
        public string? FlimsName { get; set; }
        public string? RoomName { get; set; }
        public ScreeningStatus Status { get; set; }


        //
        public DateTime? CreatedTime { get; set; }
    }
}
