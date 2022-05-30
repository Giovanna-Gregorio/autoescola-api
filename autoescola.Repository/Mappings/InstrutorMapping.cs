using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class InstrutorMapping : IEntityTypeConfiguration<Instrutor>
    {
        public void Configure(EntityTypeBuilder<Instrutor> builder)
        {
            builder.ToTable("instrutor");

            builder.HasKey(x => x.Id)
                .HasName("PK_instrutorW");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.PessoaId)
                 .HasColumnName("pessoa_id");

            builder.Property(x => x.TurnoId)
               .HasColumnName("turno_id");

            builder.HasOne(d => d.Turno)
              .WithMany(p => p.Instrutores)
              .HasForeignKey(d => d.TurnoId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Pessoa)
              .WithMany(p => p.Instrutores)
              .HasForeignKey(d => d.PessoaId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
