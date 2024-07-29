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
    public class ServiceOderConfiguration : IEntityTypeConfiguration<ServiceOder>
    {
        public void Configure(EntityTypeBuilder<ServiceOder> builder)
        {
            builder.ToTable("ServiceOder");
            builder.HasKey(x=>x.ServiceOderID);
            builder.Property(x => x.Quantity).HasDefaultValue(0).IsRequired();
            builder.Property(x=>x.TotalPrice).HasDefaultValue(0).IsRequired();

            builder.HasOne(x=>x.Service).WithMany(x=>x.ServiceOders).HasForeignKey(x=>x.ServiceID);
        }
    }
}
