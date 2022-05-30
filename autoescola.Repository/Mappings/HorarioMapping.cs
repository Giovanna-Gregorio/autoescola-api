using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class HorarioMapping : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> builder)
        {
            builder.ToTable("horario");

            builder.HasKey(x => x.Id)
                .HasName("PK_horario");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Inicio)
               .HasColumnName("inicio");

            builder.Property(x => x.Termino)
               .HasColumnName("termino");
        }
    }
}
