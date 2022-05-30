using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class TurnoService : ServiceBase<Turno, int>, ITurnoService
    {
        public TurnoService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
