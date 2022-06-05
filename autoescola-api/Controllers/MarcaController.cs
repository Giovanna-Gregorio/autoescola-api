using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace autoescola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : BaseController<Marca, int>
    {
        public MarcaController(IMarcaService service, IHttpContextAccessor httpContextAccessor) : base(service, httpContextAccessor)
        {

        }
    }
}
