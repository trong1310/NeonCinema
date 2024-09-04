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
    public class ShiftChangeConfiguration : IEntityTypeConfiguration<ShiftChange>
    {
        public void Configure(EntityTypeBuilder<ShiftChange> builder)
        {
            builder.ToTable("ShiftChange");
            builder.HasKey(x=>x.ID);
            builder.HasOne(x=>x.WorkShift).WithMany(x=>x.ShiftChanges).HasForeignKey(x=>x.WorkShiftID).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x=>x.ShiftName).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.NewShift).HasMaxLength(50).IsFixedLength();
        }
    }
}
