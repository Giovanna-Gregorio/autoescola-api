using autoescola.Domain.Const;
using autoescola.Domain.Contracts;
using autoescola.Domain.Interfaces;
using autoescola.Domain.Models;
using autoescola.Domain.Result;
using autoescola.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace autoescola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        protected readonly IUsuarioService _usuarioService;
        protected readonly ILogService _logService;
        public LoginController(IUsuarioService usuarioService, ILogService logService)
        {
            _usuarioService = usuarioService;
            _logService = logService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginContract login)
        {
            var result = new ResultLogin();

            //desbloquear usuário

            result.Success = false;

            var tentativas = _usuarioService.Get()
                .Where(x => x.Email == login.Email)
                .FirstOrDefault().Tentativas;

            var usuario = await _usuarioService.Login(login);

            Log log = new Log()
            {
                Tipo = "LOGIN",
                Data = DateTime.Now,
                Status = false
            };

            if (usuario != null)
            {
                log.UsuarioId = usuario.Id;

                if (!usuario.Ativo)
                {
                    result.Message = Mensagens.UsuarioBloqueado;
                }
                else if(usuario.Tentativas > tentativas)
                {
                    result.Message = Mensagens.UsuarioInvalido;
                }
                else
                {
                    var token = TokenService.GenerateToken(usuario);

                    log.Status = true;

                    result.Data = new { usuario, token };
                    result.Message = Mensagens.SucessoLogin;
                    result.Success = true;
                }
            } 
            else
            {
                result.Message = Mensagens.ErroBusca;
            }

            log.Dados = $"Origem: {GetIpAddress()} | {result.Message}";

            await _logService.Insert(log);

            return Ok(result);
        }

        private string GetIpAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            var ippaddress = host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            return ippaddress.ToString();
        }
    }
}
