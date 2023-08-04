using ModuloFront.Business.Utils;

namespace ModuloFront.Models
{
    public class CalculadoraModel
    {
        public OperacaoCalculadora Operacao { get; set; }
        public List<decimal> Valores { get; set; }
    }
}
