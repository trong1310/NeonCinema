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
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket");
            builder.HasKey(x=>x.TicketID);
            builder.Property(x => x.Price).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.BarCode).HasDefaultValue(123).IsRequired();
            //
            builder.HasOne(x=>x.Customers).WithMany(x=>x.Ticket).HasForeignKey(x=>x.CustomerID);
            builder.HasOne(x => x.Seats).WithMany(x => x.Ticket).HasForeignKey(x=>x.SeatID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Screening).WithMany(x => x.Tickets).HasForeignKey(x => x.TicketID);
            builder.HasOne(x => x.BookTickets).WithMany(x => x.Tickets).HasForeignKey(x => x.TicketID);


        }
    }
}
