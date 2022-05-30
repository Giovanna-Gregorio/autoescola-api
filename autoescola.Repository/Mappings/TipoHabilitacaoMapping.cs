using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class TipoHabilitacaoMapping : IEntityTypeConfiguration<TipoHabilitacao>
    {
        public void Configure(EntityTypeBuilder<TipoHabilitacao> builder)
        {
            builder.ToTable("tipo_habilitacao");

            builder.HasKey(x => x.Id)
                .HasName("PK_tipo_habilitacao");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Descricao)
               .HasColumnName("descricao");
        }
    }
}
