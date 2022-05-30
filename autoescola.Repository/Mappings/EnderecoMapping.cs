using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");

            builder.HasKey(x => x.Id)
                .HasName("PK_enderco");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Logradouro)
               .HasColumnName("logradouro");

            builder.Property(x => x.Bairro)
               .HasColumnName("bairro");

            builder.Property(x => x.CEP)
               .HasColumnName("cep");

            builder.Property(x => x.Cidade)
               .HasColumnName("cidade");

            builder.Property(x => x.Estado)
               .HasColumnName("estado");
        }
    }
}
