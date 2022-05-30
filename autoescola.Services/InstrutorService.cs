using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class InstrutorService : ServiceBase<Instrutor, int>, IInstrutorService
    {
        public InstrutorService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
