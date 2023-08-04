using Microsoft.AspNetCore.Mvc;
using ModuloFront.Business.Utils;
using ModuloFront.Models;

namespace ModuloFront.Controllers
{
    [ApiController]
    [Route("api/Contador")]
    public class ContadorController : Controller
    {
        private static Contador _contador = new Contador();

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var list = new List<Contador>()
            {
                new Contador(),
            new Contador(),
            new Contador(),
            new Contador(),
            new Contador(),
        };

            return Ok(list);
        }

        [HttpPost("Initialize")]
        public IActionResult Inicialize([FromBody] ContadorModel contador)
        {
            _contador = new Contador();
            _contador.ContagemAtual = contador.ValorInicial;

            return Ok("O contador foi inicializado com sucesso!");
        }

        [HttpGet("AddValueGet")]
        public IActionResult AddValueGet(int value)
        {
            _contador.ContagemAtual += value;
            return Ok(_contador.ContagemAtual);
        }
    }
}