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
    public class MemberShipConfiguration : IEntityTypeConfiguration<RankMember>
    {
        public void Configure(EntityTypeBuilder<RankMember> builder)
        {
            builder.ToTable("Membership");
            builder.HasKey(x=>x.ID);
          
            
            builder.Property(x=>x.Rank).HasDefaultValue(0).IsRequired();
            builder.Property(x=>x.MinPoint).HasDefaultValue(0).IsRequired();
        }
    }
}
