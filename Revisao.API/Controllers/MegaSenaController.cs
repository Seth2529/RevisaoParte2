using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Application.ViewModels.Request;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {
        private readonly IMegaSenaServices _megaSenaService;

        public MegaSenaController(IMegaSenaServices megaSenaService)
        {
            _megaSenaService = megaSenaService;
        }

        [HttpGet(Name = "ObterTodosOsJogos")]
        public IActionResult ObterTodosOsJogos()
        {
            try
            {
                return Ok(_megaSenaService.ObterTodosOsJogos());
            }
            catch
            {
                return BadRequest("Nenhum jogo salvo"); 
            }

        }

        [HttpPost(Name = "RegistrarJogo")]
        public IActionResult RegistrarJogo(NovoRegistroMegaSenaViewModel megasena)
        {
            if (megasena.primeiroNro != megasena.segundoNro && megasena.primeiroNro != megasena.terceiroNro
                && megasena.primeiroNro != megasena.quartoNro && megasena.primeiroNro != megasena.quintoNro
                && megasena.primeiroNro != megasena.sextoNro

                && megasena.segundoNro != megasena.terceiroNro && megasena.segundoNro != megasena.quartoNro
                && megasena.segundoNro != megasena.quintoNro && megasena.segundoNro != megasena.sextoNro

                && megasena.terceiroNro != megasena.quartoNro && megasena.terceiroNro != megasena.quintoNro
                && megasena.terceiroNro != megasena.sextoNro

                && megasena.quartoNro != megasena.quintoNro && megasena.terceiroNro != megasena.sextoNro

                && megasena.quintoNro != megasena.sextoNro)
            {
                _megaSenaService.RegistrarJogo(megasena);
                return Ok("Jogo Registrado com sucesso!");
            }
            else
            {
                return BadRequest("Dados incorretos, existem números repetidos no jogo");
            }
        }
    }
}
