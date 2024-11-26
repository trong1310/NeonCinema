using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Room
{
    public class RoomUpdateRequest
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Tên phòng không được để trống.")]
        public string Name { get; set; }
        public EntityStatus Status { get; set; }
        public int SeatingCapacity { get; set; }
        [Range(1, 50, ErrorMessage = "Số hàng phải từ 1 đến 50.")]
        public int RowNumber { get; set; }
        [Range(1, 50, ErrorMessage = "Số cột phải từ 1 đến 50.")]
        public int ColumnNumber { get; set; }
        [Required(ErrorMessage = "Chọn rạp là bắt buộc.")]
        public Guid CinemasId { get; set; }
        //public List<string> SelectedSeats { get; set; }
    }
}
