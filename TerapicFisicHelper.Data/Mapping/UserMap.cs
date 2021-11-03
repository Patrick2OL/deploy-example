using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerapicFisicHelper.Entities;

namespace TerapicFisicHelper.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(u => u.Name).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Description).IsRequired().HasMaxLength(255);
            builder.Property(u => u.Birth).IsRequired();
            builder.Property(u => u.Address).IsRequired().HasMaxLength(255);
            builder.Property(u => u.Phone).IsRequired();
            builder.Property(u => u.Age).IsRequired();
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Country).IsRequired().HasMaxLength(80);
            builder.Property(u => u.Gender).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(8);

            builder.HasOne(u => u.Customer)
                .WithOne(c => c.User)
                .HasForeignKey<Customer>(u => u.UserId)
                .HasConstraintName("fk_users_customer");
            
            builder.HasOne(u => u.Specialist)
                .WithOne(s => s.User)
                .HasForeignKey<Specialist>(u => u.UserId)
                .HasConstraintName("fk_users_specialist");
        }
    }
}
