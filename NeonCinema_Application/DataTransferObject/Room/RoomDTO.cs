using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Room
{
    public class RoomDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public EntityStatus Status { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Guid CinemasId { get; set; }

        //public List<string> SelectedSeats { get; set; }
    }
}
