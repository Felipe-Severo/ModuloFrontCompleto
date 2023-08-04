using Microsoft.AspNetCore.Mvc;
using ModuloFront.Business.Utils;
using ModuloFront.Models;

namespace ModuloFront.Controllers
{
    [ApiController]
    [Route("api/Calculadora")]
    public class CalculadoraController : Controller
    {
        private static Calculadora _calculadora = null;


        [HttpPost("Inicializacao")]
        public IActionResult Inicialize([FromBody] CalculadoraModel calculadora)
        {
            _calculadora = new Calculadora(calculadora.Valores, calculadora.Operacao);
            return Ok("A calculadora foi inicializada com sucesso!");
        }

        [HttpGet("Calculo")]
        public IActionResult AddValueGet()
        {
            if (_calculadora == null)
            {
                throw new Exception("A calculadora não foi inicializada!");
            }

            return Ok(_calculadora.Calcular());
        }
    }
}