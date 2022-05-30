using autoescola.Domain.Contracts;
using autoescola.Domain.Models;
using System.Threading.Tasks;

namespace autoescola.Domain.Interfaces
{
    public interface IUsuarioService : IServiceBase<Usuario, int>
    {
        Task<Usuario> Login(LoginContract login);
    }
}
