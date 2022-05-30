using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class FrotaService : ServiceBase<Frota, int>, IFrotaService
    {
        public FrotaService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
