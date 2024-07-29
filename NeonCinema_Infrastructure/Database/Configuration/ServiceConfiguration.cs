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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(x=>x.ServiceID);
            builder.Property(x=>x.ServiceName).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Price).HasDefaultValue(0).IsRequired();
            builder.Property(x=> x.Description).HasMaxLength(256).IsFixedLength();
        }
    }
}
