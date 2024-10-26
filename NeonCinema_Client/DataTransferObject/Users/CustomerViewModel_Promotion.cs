using NeonCinema_Domain.Enum;

namespace NeonCinema_Client.DataTransferObject.Users
{
	public class CustomerViewModel_Promotion
	{
		public Guid ID { get; set; }
		public string FullName { get; set; }
		public string PassWord { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public bool Gender { get; set; }
		public string Images { get; set; }
		public DateTime DateOrBriht { get; set; }// ngày sinh nhật  
		public string Adderss { get; set; }
		public EntityStatus Status { get; set; }
		public Guid RoleID { get; set; }//mặc định role = 3(khách hàng)
		//
		public bool IsSelected { get; set; } // Thuộc tính bổ sung
	}
}
