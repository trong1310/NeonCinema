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
        [RegularExpression(@"^[\p{L}0-9\s]+$", ErrorMessage = "Tên phòng không được để trống và chứa ký tự đặc biệt.")]

        public string Name { get; set; }
        public int SeatingCapacity { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public EntityStatus Status { get; set; }

        [Required(ErrorMessage = "số hàng không được để trống.")]
        [Range(8, 15, ErrorMessage = "Số hàng phải từ 8 đến 15.")]
        public int RowNumber { get; set; }

        [Required(ErrorMessage = "số cột không được để trống")]
        [Range(8,15, ErrorMessage = "Số cột phải phải từ 8 đến 15")]
        public int ColumnNumber { get; set; }

        //[Required(ErrorMessage = "Vui lòng chọn rạp.")]
        //[NotEmptyGuid(ErrorMessage = "Vui lòng chọn rạp hợp lệ.")]
        public Guid CinemasId { get; set; } = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e");
    }
    public class NotEmptyGuidAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is Guid guid && guid == Guid.Empty)
            {
                return new ValidationResult(ErrorMessage ?? "Giá trị không hợp lệ.");
            }

            return ValidationResult.Success;
        }
        private static string NormalizeName(string name)
        {
            return string.Join(" ", name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }



}
