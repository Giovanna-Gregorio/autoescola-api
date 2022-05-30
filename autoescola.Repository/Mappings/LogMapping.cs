using autoescola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace autoescola.Repository.Mappings
{
    public class LogMapping : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("log");

            builder.HasKey(x => x.Id)
                .HasName("PK_log");

            builder.Property(x => x.Tipo)
               .HasColumnName("tipo");

            builder.Property(x => x.Status)
               .HasColumnName("status");

            builder.Property(x => x.Data)
               .HasColumnName("data");

            builder.Property(x => x.UsuarioId)
               .HasColumnName("usuario_id");

            builder.Property(x => x.Dados)
               .HasColumnName("dados");

            builder.HasOne(d => d.Usuario)
             .WithMany(p => p.Logs)
             .HasForeignKey(d => d.UsuarioId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
