using Microsoft.AspNetCore.Http;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User
{
	public class UserCreateRequest
	{
		public Guid Id { get; set; }
		//[Required(ErrorMessage = "Họ và tên không được để trống")]
  //      [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "Họ và tên không được chứa số hoặc ký tự đặc biệt.")]
        public string FullName { get; set; }

		//[Required(ErrorMessage = "Số điện thoại không được để trống")]
		//[RegularExpression(@"^(03|08|09)\d{8}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng 03, 08 hoặc 09 và có đúng 10 chữ số.")]
		public string PhoneNumber { get; set; }

		//[Required(ErrorMessage = "Email không được để trống")]
		//[EmailAddress(ErrorMessage = "Email không đúng định dạng")]
		public string Email { get; set; }

		public DateTime DateOrBriht { get; set; }
		public string? Images { get; set; }
		public bool? Gender { get; set; }
		public string? Adderss { get; set; }
		public string? PassWord { get; set; }
	}

}
