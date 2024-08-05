using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Employees
{
    public class EmployeesDTO
    {
        public Guid EmployeesID { get; set; }
        public string EmployeesName { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public List<string> Images { get; set; }
        public DateTime DateOrBriht { get; set; }
        public string Position { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
