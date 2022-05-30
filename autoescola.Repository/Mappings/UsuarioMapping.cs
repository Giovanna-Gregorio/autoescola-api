using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(x => x.Id)
                .HasName("PK_usuario");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Email)
               .HasColumnName("email");

            builder.Property(x => x.Senha)
               .HasColumnName("senha");

            builder.Property(x => x.PessoaId)
               .HasColumnName("pessoa_id");

            builder.Property(x => x.Ativo)
               .HasColumnName("ativo");

            builder.Property(x => x.Tentativas)
               .HasColumnName("tentativas");

            builder.HasOne(d => d.Pessoa)
              .WithMany(p => p.Usuarios)
              .HasForeignKey(d => d.PessoaId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
