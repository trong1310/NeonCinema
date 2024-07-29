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
    public class PromotionCustomerConfiguration : IEntityTypeConfiguration<PromotionCustomer>
    {
        public void Configure(EntityTypeBuilder<PromotionCustomer> builder)
        {
            builder.ToTable("PromotionCustomer");
            builder.HasKey(x=>x.ID);
            builder.HasOne(x=>x.Promotion).WithMany(x=>x.PromotionCustomers).HasForeignKey(x=>x.PromotionId);
            builder.HasOne(x=>x.Customers).WithMany(x=>x.PromotionCustomers).HasForeignKey(x=>x.CreatedBy);
        }
    }
}
