using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class MatriculaService : ServiceBase<Matricula, int>, IMatriculaService
    {
        public MatriculaService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
