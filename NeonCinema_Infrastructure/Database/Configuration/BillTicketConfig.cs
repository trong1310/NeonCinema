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
	public class BillTicketConfig : IEntityTypeConfiguration<BillTicket>
	{
		public void Configure(EntityTypeBuilder<BillTicket> builder)
		{
			builder.ToTable("BillTicket");
			builder.HasKey(x => new { x.BillId, x.TicketId });
			builder.HasOne(ma => ma.Bills).WithMany(m => m.BillTickets).HasForeignKey(ma => ma.BillId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(ma => ma.Tickets).WithMany(a => a.BillTickets).HasForeignKey(ma => ma.TicketId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
