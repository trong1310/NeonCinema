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
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.ToTable("Membership");
            builder.HasKey(x=>x.CustomerID);
            builder.HasOne(x => x.Customers).WithOne(x => x.MemberShips).HasForeignKey<Customers>(x => x.CreatedBy).IsRequired();
            
            builder.Property(x=>x.Rank).HasDefaultValue(0).IsRequired();
            builder.Property(x=>x.Endow).HasDefaultValue(0).IsRequired();
        }
    }
}
