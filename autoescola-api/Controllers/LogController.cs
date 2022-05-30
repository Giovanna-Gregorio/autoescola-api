using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Domain.Result;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace autoescola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        protected readonly ILogService _service;
        public LogController(ILogService service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual IActionResult Get([FromQuery] int? usuarioId, DateTime? data, int limit = 0, int offset = 0)
        {
            var result = new ListResultBase<IList<Log>>();

            try
            {
                var list = new List<Log>();

                var query = _service.Get().AsNoTracking();

                result.Count = query.Count();

                if (limit != 0 || offset != 0)
                {
                    query = query
                    .Skip(offset)
                    .Take(limit).AsQueryable();
                }

                if (usuarioId != null)
                {
                    query = query.Where(x => x.UsuarioId == usuarioId.Value);
                }

                if (data != null)
                {
                    query = query.Where(x => x.Data == data.Value);
                }

                //retornar o usuário

                list = query.ToList();

                result.Data = list;

                result.Success = true;
                result.Message = "Consulta executada com sucesso";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocorreu um erro ao recuperar as informações.";
            }

            return Ok(result);
        }
    }
}
