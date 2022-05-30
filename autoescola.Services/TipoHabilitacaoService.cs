using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class TipoHabilitacaoService: ServiceBase<TipoHabilitacao, int>, ITipoHabilitacaoService
    {
        public TipoHabilitacaoService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
