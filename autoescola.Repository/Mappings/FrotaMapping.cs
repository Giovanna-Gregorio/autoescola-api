using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class FrotaMapping : IEntityTypeConfiguration<Frota>
    {
        public void Configure(EntityTypeBuilder<Frota> builder)
        {
            builder.ToTable("frota");

            builder.HasKey(x => x.Id)
                .HasName("PK_frota");

            builder.Property(x => x.Id)
                 .HasColumnName("id");

            builder.Property(x => x.Ano)
               .HasColumnName("ano");

            builder.Property(x => x.MarcaId)
               .HasColumnName("marca_id");

            builder.Property(x => x.Modelo)
               .HasColumnName("modelo");

            builder.Property(x => x.Cor)
               .HasColumnName("cor");

            builder.Property(x => x.Placa)
               .HasColumnName("placa");

            builder.Property(x => x.Observacao)
              .HasColumnName("observacao");

            builder.HasOne(d => d.Marca)
              .WithMany(p => p.Frotas)
              .HasForeignKey(d => d.MarcaId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
