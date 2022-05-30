using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class EnderecoService : ServiceBase<Endereco, int>, IEnderecoService
    {
        public EnderecoService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
