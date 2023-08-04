using Microsoft.AspNetCore.Mvc;
using ModuloFront.Business.Genericos;
using ModuloFront.Models;

namespace ModuloFront.Controllers
{
    [ApiController]
    [Route("api/Pessoas")]
    public class PessoaController : Controller
    {
        [HttpGet("Get")]
        public ActionResult Get()
        {
            var pessoasCadastradas = new List<PessoaModel>();

            foreach(var pessoa in Pessoa.PessoasCadastradas)
            {
                var auxPessoa = new PessoaModel();
                auxPessoa.Id = pessoa.Id;
                auxPessoa.Nome = pessoa.Nome;

                pessoasCadastradas.Add(auxPessoa);
            }

            return Ok(pessoasCadastradas);
        }

        [HttpPost("Create")]
        public ActionResult Create([FromBody]PessoaModel pessoa)
        {
            var auxPessoa = new Pessoa();
            auxPessoa.Nome = pessoa.Nome;

            Pessoa.PessoasCadastradas.Add(auxPessoa);

            return Ok("Pessoa cadastrada com sucesso!");
        }

        [HttpPut("Update")]
        public ActionResult Update(long id, [FromBody]PessoaModel pessoaAtualizada)
        {
            var pessoa = Pessoa.PessoasCadastradas.First(x => x.Id == id);
            if (pessoa == null)
            {
                return BadRequest("Pessoa não cadastrada com o ID informado!");
            }

            pessoa.Nome = pessoaAtualizada.Nome;

            return Ok("Cadastro alterado com sucesso!");
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(long id)
        {
            var pessoa = Pessoa.PessoasCadastradas.First(x => x.Id == id);
            if (pessoa == null)
            {
                return BadRequest("Pessoa não cadastrada com o ID informado!");
            }

            Pessoa.PessoasCadastradas.Remove(pessoa);

            return Ok("Pessoa excluída com sucesso!");
        }
    }
}