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
    class SubscriptionPlanMap : IEntityTypeConfiguration<SubscriptionPlan>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPlan> builder)
        {
            builder.ToTable("subscription_plans");
            builder.HasKey(sp => sp.Id);
            builder.Property(sp => sp.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(sp => sp.Name).IsRequired().HasMaxLength(50);
            builder.Property(sp => sp.Description).IsRequired().HasMaxLength(255);
            builder.Property(sp => sp.Cost).IsRequired().HasMaxLength(50);
        }
    }
}
