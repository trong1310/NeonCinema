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
    public class BillsConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TotalPrice).HasDefaultValue(0);
            builder.HasOne(x => x.Users).WithMany(x => x.Bills).HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.NoAction);
           
        }
    }
}
