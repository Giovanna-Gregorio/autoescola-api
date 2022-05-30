using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class AgendaService : ServiceBase<Agenda, int>, IAgendaService
    {
        public AgendaService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
