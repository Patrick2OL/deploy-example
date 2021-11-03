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
    public class TagSessionMap : IEntityTypeConfiguration<TagSession>
    {
        public void Configure(EntityTypeBuilder<TagSession> builder)
        {
            builder.ToTable("tag_sessions");
            builder.HasKey(ts => new { ts.TagId, ts.SessionId });

            builder.HasOne(ts => ts.Tag)
                .WithMany(ts => ts.TagSessions)
                .HasForeignKey(ts => ts.TagId)
                .HasConstraintName("fk_tagsession_tag");
            
            builder.HasOne(ts => ts.Session)
                .WithMany(s => s.TagSessions)
                .HasForeignKey(ts => ts.SessionId)
                .HasConstraintName("fk_tagsession_session");
        }
    }
}
