using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Bills
{
    public class BillDTO
    {
        public DateTime SoldDate { get; set; } = DateTime.Now;
        public decimal TotalMoney { get; set; }
        public EntityStatus Status { get; set; }
    }
}
