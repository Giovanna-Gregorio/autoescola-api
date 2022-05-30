using autoescola.Domain.Models;
using autoescola.Repository.Mappings;
using Microsoft.EntityFrameworkCore;

namespace autoescola.Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options) { }

        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Frota> Frota { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Instrutor> Instrutor { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<TipoHabilitacao> TipoHabilitacao { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Log> Log { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgendaMapping());
            builder.ApplyConfiguration(new AlunoMapping());
            builder.ApplyConfiguration(new EnderecoMapping());
            builder.ApplyConfiguration(new FrotaMapping());
            builder.ApplyConfiguration(new HorarioMapping());
            builder.ApplyConfiguration(new InstrutorMapping());
            builder.ApplyConfiguration(new MarcaMapping());
            builder.ApplyConfiguration(new MatriculaMapping());
            builder.ApplyConfiguration(new PessoaMapping());
            builder.ApplyConfiguration(new TipoHabilitacaoMapping());
            builder.ApplyConfiguration(new TurnoMapping());
            builder.ApplyConfiguration(new UsuarioMapping());
            builder.ApplyConfiguration(new LogMapping());
        }
    }
}
