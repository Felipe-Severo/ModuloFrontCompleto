namespace ModuloFront.Business.Utils
{
    public enum OperacaoCalculadora
    {
        Soma = 1,
        Subtracao = 2,
        Divisao = 3,
        Multiplicacao = 4,
    }
    public class Calculadora
    {
        private bool Calculado { get; set; } = false;
        private OperacaoCalculadora Operacao { get; set; }
        private List<decimal> Valores { get; set; }


        public Calculadora(List<decimal> valores, OperacaoCalculadora operacao)
        {
            if (valores == null || valores.Count == 0)
            {
                throw new ArgumentException("A lista de valores inválida. A lista deve ser declarada e conter pelo menos um valor.");
            }

            Valores = valores;
            Operacao = operacao;
        }

        public decimal Calcular()
        {
            decimal resultado = 0;
            if (Calculado)
            {
                throw new Exception("O calculo já foi realizado. Inicialize a calculadora novamente!");
            }

            switch (Operacao)
            {
                case OperacaoCalculadora.Soma:
                    resultado = Soma();
                    break;
                case OperacaoCalculadora.Subtracao:
                    resultado = Subtracao();
                    break;
                case OperacaoCalculadora.Divisao:
                    resultado = Divisao();
                    break;
                case OperacaoCalculadora.Multiplicacao:
                    resultado = Multiplicacao();
                    break;
            }

            Calculado = true;
            return resultado;
        }

        private decimal Soma()
        {
            var valor = Valores[0];
            for (int i = 1; i < Valores.Count; i++)
            {
                valor += Valores[i];
            }
            return valor;
        }
        private decimal Subtracao()
        {
            var valor = Valores[0];
            for (int i = 1; i < Valores.Count; i++)
            {
                valor -= Valores[i];
            }
            return valor;
        }
        private decimal Divisao()
        {
            var valor = Valores[0];
            for (int i = 1; i < Valores.Count; i++)
            {
                valor /= Valores[i];
            }
            return valor;
        }
        private decimal Multiplicacao()
        {
            var valor = Valores[0];
            for (int i = 1; i < Valores.Count; i++)
            {
                valor *= Valores[i];
            }
            return valor;
        }
    }
}
