using Microsoft.AspNetCore.Mvc;
using ModuloFront.Business.Utils;
using ModuloFront.Models;

namespace ModuloFront.Controllers
{
    [ApiController]
    [Route("api/Calculadora2")]
    public class Calculadora2Controller : Controller
    {
        static Calculadora2 _calculadora2 = null;

        [HttpPost("Inicializacao")]
        public IActionResult Inicializacao([FromBody] Calculadora2Model calculadora2)
        {
            _calculadora2 = new Calculadora2(calculadora2.Valores, calculadora2.Operacao);

            return Ok("O contador foi inicializado com sucesso!");
        }

        [HttpGet("Calculo")]
        public IActionResult Calculo()
        {
            return Ok(_calculadora2.Calcular());
        }
    }
}
