using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("aluno");

            builder.HasKey(x => x.Id)
                .HasName("PK_aluno");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.PessoaId)
                 .HasColumnName("pessoa_id");

            builder.Property(x => x.RG)
               .HasColumnName("rg");

            builder.Property(x => x.Profissao)
               .HasColumnName("profissao");

            builder.Property(x => x.NomeMae)
               .HasColumnName("nome_mae");

            builder.Property(x => x.NomePai)
               .HasColumnName("nome_pai");

            builder.HasOne(d => d.Pessoa)
              .WithMany(p => p.Alunos)
              .HasForeignKey(d => d.PessoaId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
