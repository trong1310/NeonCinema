using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowRelease
{
    public class CreateShowReleaseDTO
    {
        public Guid MovieID { get; set; }
        public Guid RoomID { get; set; }
        public DateTime TimeRelease { get; set; }
        public DateTime DateRelease { get; set; }
        public EntityStatus Status { get; set; }


        public bool IsValid()
        {
            // Kiểm tra các thuộc tính MovieID và RoomID có hợp lệ không
            if (MovieID == Guid.Empty)
            {
                throw new ArgumentException("MovieID cannot be empty.");
            }
            if (RoomID == Guid.Empty)
            {
                throw new ArgumentException("RoomID cannot be empty.");
            }

            // Kiểm tra TimeRelease và DateRelease có hợp lệ không
            if (DateRelease.Date < DateTime.Now.Date)
            {
                throw new ArgumentException("DateRelease cannot be in the past.");
            }
            if (TimeRelease.TimeOfDay < DateTime.Now.TimeOfDay && DateRelease.Date == DateTime.Now.Date)
            {
                throw new ArgumentException("TimeRelease cannot be in the past on the same day.");
            }

            return true;
        }
    }


}
