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
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");
            builder.HasKey(x=>x.ID);
            builder.Property(x => x.Price).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.QrCode).HasDefaultValue(123).IsRequired();
            //
            builder.HasOne(x=>x.Customers).WithMany(x=>x.Ticket).HasForeignKey(x=>x.CustomerID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Seat).WithMany(x => x.Ticket).HasForeignKey(x=>x.SeatID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Screening).WithMany(x => x.Ticket).HasForeignKey(x => x.ScreeningID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Surcharges).WithMany(x => x.Ticket).HasForeignKey(x => x.SurchargeID).OnDelete(DeleteBehavior.NoAction);
          

        }
    }
}
