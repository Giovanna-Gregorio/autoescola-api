using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class AgendaMapping : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("agenda");

            builder.HasKey(x => x.Id)
                .HasName("PK_agenda");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.MatriculaId)
               .HasColumnName("matricula_id");

            builder.Property(x => x.MatriculaId)
               .HasColumnName("matricula_id");

            builder.Property(x => x.InstrutorId)
               .HasColumnName("instrutor_id");

            builder.Property(x => x.HorarioId)
               .HasColumnName("horario_id");

            builder.HasOne(d => d.Matricula)
              .WithMany(p => p.Agenda)
              .HasForeignKey(d => d.MatriculaId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Instrutor)
              .WithMany(p => p.Agenda)
              .HasForeignKey(d => d.InstrutorId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Horario)
              .WithMany(p => p.Agenda)
              .HasForeignKey(d => d.HorarioId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
