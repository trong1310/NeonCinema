﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actor");
            builder.HasKey(x=>x.ActorID);

            builder.Property(x=>x.FullName).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.StageName).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Address).HasMaxLength(256).IsFixedLength();
            builder.Property(x=>x.Nationality).HasMaxLength(256).IsFixedLength();
            builder.Property(x=>x.Biography).HasMaxLength(256).IsFixedLength();
            builder.Property(x=>x.Awards).HasMaxLength(256).IsFixedLength();
            builder.Property(x => x.Images).HasConversion(
                    c => JsonConvert.SerializeObject(c),
                    c => JsonConvert.DeserializeObject<string>(c));



        }
    }
}
