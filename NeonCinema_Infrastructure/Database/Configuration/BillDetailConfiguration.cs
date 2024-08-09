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
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.ToTable(nameof(BillDetail));
            builder.HasKey(x => x.BillDetailID);
            builder.Property(x => x.Price).HasDefaultValue(0);
            builder.Property(x=>x.NumberOfProduct).HasDefaultValue(0).IsFixedLength();

            builder.HasOne(x => x.Customers).WithMany(x => x.BillDetail).HasForeignKey(x => x.CustomerID);
            builder.HasOne(x => x.Ticket).WithMany(x => x.BillDetail).HasForeignKey(x => x.TicketID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.PaymentMethod).WithMany(x => x.BillDetail).HasForeignKey(x => x.PaymentID);
            builder.HasOne(x=>x.ServiceOder).WithMany(x=>x.BillDetail).HasForeignKey(x=>x.ServiceOderID);
            builder.HasOne(x => x.Employees).WithMany(x => x.BillDetail).HasForeignKey(x => x.EmployeeID);
            builder.HasOne(x=>x.Promotion).WithMany(x=>x.BillDetail).HasForeignKey(x=>x.PromotionID);
        }
    }
}
