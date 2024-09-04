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
    public class WorkShiftConfiguration : IEntityTypeConfiguration<WorkShift>
    {
        public void Configure(EntityTypeBuilder<WorkShift> builder)
        {
            builder.ToTable("WorkShift");
            builder.HasKey(x=>x.ID);
            builder.HasOne(x=>x.Users).WithMany(x=>x.Workshifts).HasForeignKey(x=>x.UserID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
