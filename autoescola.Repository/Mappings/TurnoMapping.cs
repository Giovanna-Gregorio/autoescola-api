using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class TurnoMapping : IEntityTypeConfiguration<Turno>
    {
        public void Configure(EntityTypeBuilder<Turno> builder)
        {
            builder.ToTable("turno");

            builder.HasKey(x => x.Id)
                .HasName("PK_turno");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Descricao)
               .HasColumnName("descricao");
        }
    }
}
