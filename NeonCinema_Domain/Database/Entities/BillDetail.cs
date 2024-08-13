using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class BillDetail : EntityBase
    {
        public Guid BillDetailID { get; set; }
        public Guid BillID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid TicketID { get; set; }
        public Guid PaymentID { get; set; }
        public Guid ServiceOderID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PromotionID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
        public DateTime SoldDate { get; set; } = DateTime.Now;
        public decimal TotalMoney { get; set; }
        public EntityStatus Status { get; set; }
        ///

     
        public virtual Customers? Customers { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual ServiceOder? ServiceOder { get; set; }
        public virtual Employees? Employees { get; set; }
        public virtual Promotion? Promotion { get; set; }
    }
}
