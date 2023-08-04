using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFront.Business.Genericos
{
    public class Pessoa
    {
        private static long _currentId = 3;
        public static List<Pessoa> PessoasCadastradas = new List<Pessoa>()
        {
            new Pessoa()
            {
                Id = 1,
                Nome = "Marco A. Angelo",
            },
            new Pessoa()
            {
                Id = 2,
                Nome = "Joãozinho",
            },
            new Pessoa()
            {
                Id = 3,
                Nome = "Mariazinha",
            },
        };

        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public Pessoa()
        {
            Id = ++_currentId;
        }
    }
}