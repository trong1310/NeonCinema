using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace NeonCinema_Domain.Database.Entities
{
    public class TicketPriceSetting : EntityBase
    {
        [Key]
        public Guid ID { get; set; }
        public decimal PriceBefore17hWeekDay { get; set; }
        public decimal PriceAfter17hWeekDay { get; set; }
        public decimal PriceBefore17hWeekeend { get; set; }
        public decimal PriceAfter17hWeekeend { get; set; }
        public decimal Surcharge3D { get; set; }
        public decimal Surcharge4D { get; set; }
        public decimal SurchargeIMAX { get; set; }
        public decimal SurchargeVIP { get; set; }
        public decimal SurchargeCouple { get; set; }
        public virtual ICollection<TicketPrice>? TicketPrices { get; set; }
    }
}