using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class MatriculaMapping : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("matricula");

            builder.HasKey(x => x.Id)
                .HasName("PK_matricula");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.AlunoId)
               .HasColumnName("aluno_id");

            builder.Property(x => x.TipoHabilitacaoId)
               .HasColumnName("tipo_habilitacao_id");

            builder.HasOne(d => d.Aluno)
              .WithMany(p => p.Matriculas)
              .HasForeignKey(d => d.AlunoId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.TipoHabilitacao)
              .WithMany(p => p.Matriculas)
              .HasForeignKey(d => d.TipoHabilitacaoId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
