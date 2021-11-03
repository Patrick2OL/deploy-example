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
    public class SpecialistMap : IEntityTypeConfiguration<Specialist>
    {
        public void Configure(EntityTypeBuilder<Specialist> builder)
        {
            builder.ToTable("specialists");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(s => s.Specialty).IsRequired().HasMaxLength(50);
            
            builder.HasMany(s => s.Sessions)
                .WithOne(ss => ss.Specialist)
                .HasForeignKey(ss => ss.SpecialistId)
                .HasConstraintName("fk_specialist_session");
        }
    }
}
