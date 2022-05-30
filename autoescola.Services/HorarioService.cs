using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class HorarioService : ServiceBase<Horario, int>, IHorarioService
    {
        public HorarioService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
