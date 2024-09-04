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
    public class RowofSeatConfiguration : IEntityTypeConfiguration<RowofSeat>
    {
        public void Configure(EntityTypeBuilder<RowofSeat> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Seat).WithMany(x => x.RowofSeats).HasForeignKey(x => x.SeatID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
