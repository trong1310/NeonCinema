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
    public class ShowtimeConfiguration : IEntityTypeConfiguration<ShowTime>
    {
        public void Configure(EntityTypeBuilder<ShowTime> builder)
        {
            builder.HasKey(x => x.ShowTimeID);
            builder.HasOne(x => x.Ticket).WithMany(x => x.ShowTimes).HasForeignKey(x => x.ShowTimeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Screening).WithMany(x => x.ShowTimes).HasForeignKey(x => x.ShowTimeID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
