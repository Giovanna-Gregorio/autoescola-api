using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace autoescola.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FrotaController : BaseController<Frota, int>
    {   
        protected readonly ILogService _logService;
        public FrotaController(IFrotaService service, IHttpContextAccessor httpContextAccessor, ILogService logService) : base(service, httpContextAccessor)
        {
            _logService = logService;
        }

        [HttpPut()]
        public override async Task<IActionResult> Put(Frota model)
        {
            var frota = base._service.Get(model.Id).FirstOrDefault();

            var put = await base.Put(model);

            Log log = new Log()
            {
                Tipo = "ALTERAÇÃO",
                Data = DateTime.Now,
                Status = true,
                UsuarioId = base.GetUsuarioClaims(),
                Dados = JsonSerializer.Serialize(frota)
            };

            await _logService.Insert(log);

            return put;
        }


        [HttpDelete("{id}")]
        public override async Task<IActionResult> Delete(int id)
        {
            var frota = base._service.Get(id).FirstOrDefault();

            var delete = await base.Delete(id);

            Log log = new Log()
            {
                Tipo = "EXCLUSÃO",
                Data = DateTime.Now,
                Status = true,
                UsuarioId = base.GetUsuarioClaims(),
                Dados = JsonSerializer.Serialize(frota)
            };

            await _logService.Insert(log);

            return delete;
        }


    }
}
