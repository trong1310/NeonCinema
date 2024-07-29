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
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.ToTable("Point");
            builder.HasKey(x=>x.PointID);
            builder.Property(x=>x.TotalPoint).HasDefaultValue(0).IsFixedLength();
            builder.HasOne(x=>x.Customers).WithMany(x=>x.Points).HasForeignKey(x=>x.CustomerID);
        }
    }
}
