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
    public class ReviewMap : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("reviews");
            builder.HasKey(r => new { r.CustomerId, r.SpecialistId });
            builder.Property(r => r.Description).IsRequired().HasMaxLength(255);
            builder.Property(r => r.Rank).IsRequired();
            
            builder.HasOne(r => r.Customer)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CustomerId)
                .HasConstraintName("fk_review_customer");
            
            builder.HasOne(r => r.Specialist)
                .WithMany(s => s.Reviews)
                .HasForeignKey(r => r.SpecialistId)
                .HasConstraintName("fk_review_specialist")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
