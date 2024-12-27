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
    public class FoodComboConfiguration : IEntityTypeConfiguration<FoodCombo>
    {
        public void Configure(EntityTypeBuilder<FoodCombo> builder)
        {
            builder.ToTable("FoodCombo");
            builder.HasKey(x=>x.ID);
            builder.Property(x=>x.TotalPrice).HasDefaultValue(0).IsRequired();
        }
    }
}
