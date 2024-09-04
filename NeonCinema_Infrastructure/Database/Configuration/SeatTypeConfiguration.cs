﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class SeatTypeConfiguration : IEntityTypeConfiguration<SeatType>
    {
        public void Configure(EntityTypeBuilder<SeatType> builder)
        {
            builder.ToTable("SeatType");
            builder.HasKey(x=>x.ID);
            builder.HasOne(x=>x.Seats).WithMany(x=>x.SeatType).HasForeignKey(x=>x.SeatID).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x=>x.SeatTypeName);
            builder.Property(x=>x.Price).HasDefaultValue(0).IsRequired();
        }
    }
}
