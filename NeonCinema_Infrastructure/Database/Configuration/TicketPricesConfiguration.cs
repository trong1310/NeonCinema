using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class TicketPricesConfiguration : IEntityTypeConfiguration<TicketPrice>
    {
        public void Configure(EntityTypeBuilder<TicketPrice> builder)
        {
            builder.ToTable("TicketPrice");
            builder.HasKey(x=>x.ID);    
            builder.HasOne(x => x.SeatTypes).WithMany(x => x.TicketPrice).HasForeignKey(x=>x.SeatTypeID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.TicketPriceSetting).WithMany(x => x.TicketPrices).HasForeignKey(x=>x.TicketPriceSettingID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Screening).WithMany(x => x.TicketPrice).HasForeignKey(x => x.ScreeningID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ShowTimes).WithMany(x => x.TicketPrices).HasForeignKey(x => x.ShowTimeID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
