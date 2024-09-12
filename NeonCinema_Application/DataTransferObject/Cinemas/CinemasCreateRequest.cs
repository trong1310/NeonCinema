using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Cinemas
{
    public class CinemasCreateRequest
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSite { get; set; }
        public string OpeningHours { get; set; }
        public string ClosingHours { get; set; }
        public int RoomNumber { get; set; }
        //public Guid CinemasTypeID { get; set; }
    }
}
