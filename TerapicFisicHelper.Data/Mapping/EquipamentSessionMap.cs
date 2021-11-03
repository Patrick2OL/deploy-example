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
    public class EquipamentSessionMap : IEntityTypeConfiguration<EquipamentSession>
    {
        public void Configure(EntityTypeBuilder<EquipamentSession> builder)
        {
            builder.ToTable("equipament_sessions");
            builder.HasKey(es => new { es.EquipamentId, es.SessionId });
            
            builder.HasOne(es => es.Equipament)
                .WithMany(e => e.EquipamentSessions)
                .HasForeignKey(es => es.EquipamentId)
                .HasConstraintName("fk_equipamentsession_equipament");
            
            builder.HasOne(es => es.Session)
                .WithMany(s => s.EquipamentSessions)
                .HasForeignKey(es => es.SessionId)
                .HasConstraintName("fk_equipamentsession_session");
        }
    }
}
