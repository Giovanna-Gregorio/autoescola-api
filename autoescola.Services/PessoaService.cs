using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class PessoaService : ServiceBase<Pessoa, int>, IPessoaService
    {
        public PessoaService(ApplicationDbContext db) : base(db)
        {
                
        }
    }
}
