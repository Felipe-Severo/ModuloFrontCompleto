using Microsoft.AspNetCore.Mvc;
using ModuloFront.Business.Genericos;
using ModuloFront.Models;

namespace ModuloFront.Controllers
{
    [ApiController]
    [Route("api/Carros")]
    public class CarroController : Controller
    {
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var carrosCadastrados = new List<CarroModel>();

            foreach (var carro in Carro.CarrosCadastrados)
            {
                var auxCarro = new CarroModel();
                auxCarro.Id = carro.Id;
                auxCarro.Nome = carro.Nome;
                auxCarro.Ano = carro.Ano;
                auxCarro.Placa = carro.Placa;

                carrosCadastrados.Add(auxCarro);
            }

            return Ok(carrosCadastrados);
        }




        [HttpGet("Get")]
        public ActionResult Get(string placa)
        {
            var carro = Carro.CarrosCadastrados.First(x => x.Placa == placa);
            if (carro == null)
            {
                return BadRequest("Carro não cadastrado com o ID informado!");
            }


            return Ok(carro);
        }

        //Vizualiza todos os carros em que o ano de fabricação esteja entre um valor minímo e máximo que serão informados
        [HttpGet("GetRange")]
        public ActionResult GetRange(long anoInicial, long anoFinal)
        {
            var carrosBuscados = new List<Carro>();

            foreach (var carro in Carro.CarrosCadastrados)
            {
                if (carro.Ano >= anoInicial && carro.Ano <= anoFinal)
                {
                    carrosBuscados.Add(carro);
                }
                else if (carrosBuscados == null)
                {
                    return BadRequest("Carro não cadastrado com o ID informado!");
                }
            }


            return Ok(carrosBuscados);
        }




        //[HttpGet("GetRange")]
        //public ActionResult GetRange(long anoInicial, long anoFinal)
        //{
        //    List<CarroModel> carrosBuscados = new List<CarroModel>();

        //    if (Carro.CarrosCadastrados.Any(carro.Ano >= anoInicial && carro.Ano <= anoFinal) 
        //    {
        //        carrosBuscados.AddRange(Carro);
        //    }



        //    return Ok(carrosBuscados);
        //}







        //[HttpPost]  
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost("Create")]
        public ActionResult Create([FromBody] CarroModel carro)
        {
            var auxCarro = new Carro();
            auxCarro.Nome = carro.Nome;
            auxCarro.Ano = carro.Ano;
            auxCarro.Placa = carro.Placa;

            Carro.CarrosCadastrados.Add(auxCarro);

            return Ok("Carro cadastrado com sucesso!");
        }



        [HttpPut("Update")]
        public ActionResult Update(long id, [FromBody] CarroModel carroAtualizado)
        {
            var carro = Carro.CarrosCadastrados.First(x => x.Id == id);
            if (carro == null)
            {
                return BadRequest("Carro não cadastrado com o ID informado!");
            }

            carro.Nome = carroAtualizado.Nome;
            carro.Ano = carroAtualizado.Ano;
            carro.Placa = carroAtualizado.Placa;



            return Ok("Cadastro alterado com sucesso!");
        }



        [HttpDelete("Delete")]
        public ActionResult Delete(long id)
        {
            var carro = Carro.CarrosCadastrados.First(x => x.Id == id);
            if (carro == null)
            {
                return BadRequest("Carro não cadastrado com o ID informado!");
            }

            Carro.CarrosCadastrados.Remove(carro);

            return Ok("Carro excluído com sucesso!");
        }


    }
}


    