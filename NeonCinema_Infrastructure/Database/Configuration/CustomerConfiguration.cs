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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x=>x.CustomerID);
            builder.Property(x => x.CustomerName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.PhoneNumber).HasMaxLength(10).IsFixedLength();
            builder.Property(x => x.Email).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.PassWord).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Sex).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Images).HasConversion(
                   c => JsonConvert.SerializeObject(c),
                   c => JsonConvert.DeserializeObject<List<string>>(c));
            builder.HasOne(x => x.BookTickets).WithMany(x => x.Customers).HasForeignKey(x => x.CustomerID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
