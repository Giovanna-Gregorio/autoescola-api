using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class MarcaMapping : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("marca");

            builder.HasKey(x => x.Id)
                .HasName("PK_marca");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Descricao)
               .HasColumnName("descricao");
        }
    }
}
