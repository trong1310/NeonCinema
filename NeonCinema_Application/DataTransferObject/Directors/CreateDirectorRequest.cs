using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Directors
{
    public class CreateDirectorRequest
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "Họ và tên không được chứa số hoặc ký tự đặc biệt.")]
        public string FullName { get; set; }

        public EntityStatus? Gender { get; set; }
        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Quốc tịch là bắt buộc.")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "Quốc gia không được chứa số hoặc ký tự đặc biệt.")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "Tiểu sử là bắt buộc.")]
        public string? Biography { get; set; }
        public EntityStatus Status { get; set; }
    }
}

