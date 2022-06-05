using autoescola.Domain.Contracts;
using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Repository.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace autoescola.Services
{
    public class UsuarioService : ServiceBase<Usuario, int>, IUsuarioService
    {
        public UsuarioService(ApplicationDbContext db) : base(db)
        {

        }

        public override IQueryable<Usuario> Get()
        {
            return _db.Set<Usuario>()
                .Include(x => x.Pessoa)
                .AsQueryable();
        }

        public override async Task<int> Insert(Usuario model)
        {
            GerarHash(model, model.Senha);

            _db.Add<Usuario>(model);

            return await _db.SaveChangesAsync();
        }

        public override async Task<int> Update(Usuario model)
        {
            GerarHash(model, model.Senha);

            _db.Update<Usuario>(model);

            return await _db.SaveChangesAsync();

        }
        private void GerarHash(Usuario usuario, string senha)
        {
            usuario.Senha = new PasswordHasher<Usuario>().HashPassword(usuario, senha);
        }

        private bool VerificarSenha(Usuario usuario, string senhaInformada)
        {
            return new PasswordHasher<Usuario>().VerifyHashedPassword(usuario, usuario.Senha, senhaInformada) != PasswordVerificationResult.Failed;
        }

        public async Task<Usuario> Login(LoginContract login)
        {
            var usuario = base.Get()
                .Where(x => x.Email == login.Email)
                .FirstOrDefault();

            if(usuario == null)
            {
                return null;
            }
            else
            {
                if (usuario.Tentativas >= 3)
                    usuario.Ativo = false;

                if (!VerificarSenha(usuario, login.Senha) || !usuario.Ativo)
                    usuario.Tentativas += 1;
                else
                {
                    usuario.Tentativas = 0;
                    usuario.Ativo = true;
                }

                await base.Update(usuario);
            }

            return usuario;
        }
    }
}
