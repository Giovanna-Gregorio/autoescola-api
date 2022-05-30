using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace autoescola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : BaseController<Usuario, int>
    {
        public UsuarioController(IUsuarioService service, IHttpContextAccessor httpContextAccessor) : base(service, httpContextAccessor)
        {

        }
    }
}
