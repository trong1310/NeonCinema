using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BillDetails
{
    public class BillDetailsCreateRequest
    {
        public Guid CustomerID { get; set; }
        public Guid TicketID { get; set; }
        public Guid PaymentID { get; set; }
        public Guid ServiceOderID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PromotionID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
        public decimal TotalMoney { get; set; }
    }
}
