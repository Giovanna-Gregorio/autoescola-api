using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoa");

            builder.HasKey(x => x.Id)
                .HasName("PK_pessoa");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Nome)
               .HasColumnName("nome");

            builder.Property(x => x.CPF)
               .HasColumnName("cpf");

            builder.Property(x => x.Sexo)
               .HasColumnName("sexo");

            builder.Property(x => x.Nascimento)
               .HasColumnName("nascimento");

            builder.Property(x => x.Email)
               .HasColumnName("email");

            builder.Property(x => x.Telefone)
               .HasColumnName("telefone");

            builder.Property(x => x.EnderecoId)
               .HasColumnName("endereco_id");

            builder.Property(x => x.NumeroEndereco)
               .HasColumnName("numero_endereco");

            builder.HasOne(d => d.Endereco)
              .WithMany(p => p.Pessoas)
              .HasForeignKey(d => d.EnderecoId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
