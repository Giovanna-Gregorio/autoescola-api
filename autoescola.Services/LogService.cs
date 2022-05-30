using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;

namespace autoescola.Services
{
    public class LogService : ServiceBase<Log, int>, ILogService
    {
        public LogService(ApplicationDbContext db) : base(db)
        {

        }
    }
}
