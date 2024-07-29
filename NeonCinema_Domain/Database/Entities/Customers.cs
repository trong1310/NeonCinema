using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Customers : EntityBase
    {
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public List<string> Images { get; set; }
        public DateTime DateOrBriht { get; set; }
        public DateTime CreateDate {  get; set; }
    }
}
