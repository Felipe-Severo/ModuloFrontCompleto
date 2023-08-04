using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFront.Business.Genericos
{
    public class Carro
    {
        private static long _currentId = 1;
        public static List<Carro> CarrosCadastrados = new List<Carro>()
        {
            new Carro()
            {
                Id = 1,
                Nome = "GM - Cruse",
                Ano = 2015,
                Placa = "IJO-0485",

            },
            new Carro()
            {
                Id = 2,
                Nome = "Honda - HRV",
                Ano = 2019,
                Placa = "MVC-0202",
            },
            new Carro()
            {
                Id = 3, 
                Nome = "Honda - Civic", 
                Ano = 2022, 
                Placa = "DNS-8080",
            },
        };

        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public long Ano { get; set; } 
        public string Placa { get; set; } = string.Empty;

        public Carro()
        {
            Id = _currentId++;
            
        }
    }
}
