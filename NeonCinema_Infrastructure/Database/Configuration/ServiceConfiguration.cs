using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using Newtonsoft.Json;
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
            builder.HasKey(x=>x.ID);
            builder.Property(x=>x.ServiceName).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Price).HasDefaultValue(0).IsRequired();
            builder.Property(x=> x.Description);
			builder.Property(x => x.Images).HasConversion(
				  c => JsonConvert.SerializeObject(c),
				  c => JsonConvert.DeserializeObject<List<string>>(c));
		}
    }
}
