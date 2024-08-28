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
    public class SurchargesConfiguration : IEntityTypeConfiguration<Surcharges>
    {
        public void Configure(EntityTypeBuilder<Surcharges> builder)
        {
            builder.HasKey(x => x.surchargeID);
            builder.HasOne(x => x.Ticket).WithMany(x => x.Surcharges).HasForeignKey(x => x.surchargeID);
        }
    }
}
