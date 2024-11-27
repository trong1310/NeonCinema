using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Room
{
    public class RoomCreateRequest
    {

       
        public Guid ID { get; set; }

        [Required(ErrorMessage = "tên phòng không được để trống.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "tên phòng không được chứa ký tự đặc biệt.")]
        public string Name { get; set; }

      
        public int SeatingCapacity { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public EntityStatus Status { get; set; }

        [Required(ErrorMessage = "số hàng không được để trống.")]
        [Range(2, int.MaxValue, ErrorMessage = "số hàng phải lớn hơn 1.")]
        public int RowNumber { get; set; }

        [Required(ErrorMessage = "số cột không được để trống")]
        [Range(2, int.MaxValue, ErrorMessage = "số cột phải lớn hơn 1")]
        public int ColumnNumber { get; set; }

        [Required(ErrorMessage = "Cinema ID is required.")]
        public Guid CinemasId { get; set; }
    }
}
