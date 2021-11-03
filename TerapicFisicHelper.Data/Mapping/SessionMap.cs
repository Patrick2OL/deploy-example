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
    public class SessionMap : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("sessions");
            builder.HasKey(ss => ss.Id);
            builder.Property(ss => ss.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(ss => ss.Title).IsRequired().HasMaxLength(50);
            builder.Property(ss => ss.Description).IsRequired().HasMaxLength(255);
            builder.Property(ss => ss.StartDate).IsRequired();
            builder.Property(ss => ss.StartHour).IsRequired().HasMaxLength(5);
            builder.Property(ss => ss.EndHour).IsRequired().HasMaxLength(5);
        }
    }
}
