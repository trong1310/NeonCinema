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
    public class PromotionTypeConfiguration : IEntityTypeConfiguration<PromotionType>
    {
        public void Configure(EntityTypeBuilder<PromotionType> builder)
        {
            builder.ToTable("PromotionType");
            builder.HasKey(x=>x.PromotionTypeID);
            builder.Property(x => x.PromotionName).HasMaxLength(50).IsFixedLength();

        }
    }
}
