using NeonCinema_Domain.Database.Base;
using NeonCinema_Infrastructure.Database.Configuration;
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
        public List<string>? Images { get; set; }
        public DateTime DateOrBriht { get; set; }
        public string? ConfirmCode { get; set; }
        public DateTimeOffset? SeenTime { get; set; }   


        //
        public virtual MemberShip? MemberShips { get; set; }
        public virtual ICollection<Ticket>? Ticket { get; set; }
        public virtual ICollection<BillDetail>? BillDetail { get; set; }
        public virtual ICollection<Point>? Points { get; set; }
        public virtual ICollection<PromotionCustomer>? PromotionCustomers { get; set; }
        public virtual ICollection<Rating>? Rating { get; set; }
        public virtual BookTickets BookTickets { get; set; }
    }
}
