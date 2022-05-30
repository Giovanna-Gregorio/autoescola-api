using autoescola.Domain.Interfaces;
using autoescola.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace autoescola.Extensions
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAgendaService, AgendaService>();
            services.AddTransient<IAlunoService, AlunoService>();
            services.AddTransient<IEnderecoService, EnderecoService>();
            services.AddTransient<IFrotaService, FrotaService>();
            services.AddTransient<IHorarioService, HorarioService>();
            services.AddTransient<IInstrutorService, InstrutorService>();
            services.AddTransient<IMarcaService, MarcaService>();
            services.AddTransient<IMatriculaService, MatriculaService>();
            services.AddTransient<IPessoaService, PessoaService>();
            services.AddTransient<ITipoHabilitacaoService, TipoHabilitacaoService>();
            services.AddTransient<ITurnoService, TurnoService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ILogService, LogService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
