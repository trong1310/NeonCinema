using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class BookTicketConfigurations : IEntityTypeConfiguration<BookTickets>
    {
        public void Configure(EntityTypeBuilder<BookTickets> builder)
        {
			builder.ToTable("BookTicket");
			builder.HasKey(x => x.ID);
            builder.HasOne(x=>x.Tickets).WithMany(x=>x.BookTickets).HasForeignKey(x=>x.TicketID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x=>x.Customers).WithMany(x=>x.BookTickets).HasForeignKey(x=>x.CustomerID).OnDelete(DeleteBehavior.NoAction);
          
        }
    }
}
