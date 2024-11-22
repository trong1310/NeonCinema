using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Database.Entities;
using System.ComponentModel.DataAnnotations;

public class TicketPriceSetting : EntityBase
{
	[Key]
	public Guid ID { get; set; }
	[Precision(18, 2)]
	public decimal? PriceBefore17hWeekDay { get; set; }
	[Precision(18, 2)]
	public decimal? PriceAfter17hWeekDay { get; set; }
	[Precision(18, 2)]
	public decimal? PriceBefore17hWeekeend { get; set; }
	[Precision(18, 2)]
	public decimal? PriceAfter17hWeekeend { get; set; }
	[Precision(18, 2)]
	public decimal? Surcharge3D { get; set; }
	[Precision(18, 2)]
	public decimal? Surcharge4D { get; set; }
	[Precision(18, 2)]
	public decimal? SurchargeIMAX { get; set; }
	[Precision(18, 2)]
	public decimal? SurchargeVIP { get; set; }
	[Precision(18, 2)]
	public decimal? SurchargeCouple { get; set; }
	public virtual ICollection<TicketPrice>? TicketPrices { get; set; }
}