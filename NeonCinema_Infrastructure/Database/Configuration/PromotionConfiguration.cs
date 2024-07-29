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
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotion");
            builder.HasKey(x=>x.PromotionID);
            builder.Property(x=>x.PromotionCode).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Description).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Quantity).HasDefaultValue(10).IsRequired();
            builder.Property(x => x.proviso).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Discount).HasMaxLength(50).IsFixedLength();
            builder.HasOne(x=>x.PromotionType).WithMany(x=>x.Promotions).HasForeignKey(x=>x.PromotionTypeID);
        }
    }
}
