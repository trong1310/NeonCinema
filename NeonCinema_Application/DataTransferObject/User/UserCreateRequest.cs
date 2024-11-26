using Microsoft.AspNetCore.Http;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User
{
    public class UserCreateRequest
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [RegularExpression(@"^(03|08|09)\d{8}$", ErrorMessage = "Số điện thoại không hợp lệ. Phải có 10 chữ số và bắt đầu bằng 03, 08, hoặc 09.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày sinh.")]
        public DateTime DateOrBriht { get; set; }

        public string Images { get; set; }

        //[Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        //[StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 ký tự trở lên.")]
        //public string PassWord { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public bool? Gender { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Adderss { get; set; }
    }

}
