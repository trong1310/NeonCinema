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
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Rating");
            builder.HasKey(x=>x.RatingID);
            builder.Property(x => x.Ratings).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(256).IsFixedLength();
            builder.HasOne(x => x.Ticket).WithMany(x => x.Rating).HasForeignKey(x => x.TicketID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x=>x.Customers).WithMany(x=>x.Rating).HasForeignKey(x=>x.CustomerID);
        }
    }
}
