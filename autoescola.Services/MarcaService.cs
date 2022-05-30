using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class MarcaService : ServiceBase<Marca, int>, IMarcaService
    {
        public MarcaService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
