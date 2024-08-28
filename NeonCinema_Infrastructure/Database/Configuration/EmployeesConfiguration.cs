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
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(x=>x.EmployeesID);
          
            builder.Property(x => x.EmployeesName).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.PassWord).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Sex).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Images).HasConversion(
                   c => JsonConvert.SerializeObject(c),
                   c => JsonConvert.DeserializeObject<List<string>>(c));
            builder.Property(x=>x.Position).HasMaxLength(50).IsFixedLength();

        }
    }
}
