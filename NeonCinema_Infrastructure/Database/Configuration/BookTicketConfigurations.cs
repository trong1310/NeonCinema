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
            builder.HasKey(x => x.BookTicketId);
          
        }
    }
}
