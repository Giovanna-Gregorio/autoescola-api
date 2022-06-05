using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace autoescola.Services
{
    public class FrotaService : ServiceBase<Frota, int>, IFrotaService
    {
        public FrotaService(ApplicationDbContext db) : base(db)
        {

        }

        public override IQueryable<Frota> Get()
        {
            return _db.Set<Frota>()
                .Include(x => x.Marca)
                .AsQueryable();
        }
    }
}
