using Microsoft.EntityFrameworkCore;
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
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x=>x.ID);
            builder.HasOne(x=>x.Roles).WithMany(x=>x.Users).HasForeignKey(x=>x.RoleID).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.FullName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.PhoneNumber).HasMaxLength(10).IsFixedLength();
            builder.Property(x => x.Email).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.PassWord).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Gender).HasMaxLength(50).IsFixedLength();
            builder.Property(x => x.Images).HasConversion(
                   c => JsonConvert.SerializeObject(c),
                   c => JsonConvert.DeserializeObject<List<string>>(c));
            
        }
    }
}
