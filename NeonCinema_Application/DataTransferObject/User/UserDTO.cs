using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.User
{
    public class UserDTO
    {
        
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Images { get; set; }
        public DateTime DateOrBriht { get; set; }// ngày sinh nhật  
        public string Adderss { get; set; }
        public EntityStatus Status { get; set; }
        public Guid RoleID { get; set; }//mặc định role = 3(khách hàng)
    }
}
