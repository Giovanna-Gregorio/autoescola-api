using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class AlunoService : ServiceBase<Aluno, int>, IAlunoService
    {
        public AlunoService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
