using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowTime
{
    public class ShowTimeDTO
    {
        public Guid ID { get; set; }
        public TimeSpan StartTime { get; set; }  // Lưu trữ thời gian trong ngày
        public TimeSpan EndTime { get; set; }
        public EntityStatus Status { get; set; }
    }
}
