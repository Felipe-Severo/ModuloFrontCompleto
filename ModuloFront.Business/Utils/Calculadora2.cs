using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFront.Business.Utils
{
    public enum OperacaoCalculadora2
    {
        Soma = 1,
        Subtracao = 2,
        Divisao = 3,
        Multiplicao = 4,
    }

    public class Calculadora2
    {
        private OperacaoCalculadora2 Operacao { get; set; }
        private List<decimal> Valores { get; set; }

        public Calculadora2(List<decimal> valores, OperacaoCalculadora2 operacao)
        {
            Valores = valores;
            Operacao = operacao;
        }

        public decimal Calcular()
        {
            decimal resultado = 0;

            switch (Operacao)
            {
                case OperacaoCalculadora2.Soma:
                    resultado = Soma();
                    break;
                case OperacaoCalculadora2.Subtracao:
                    resultado = Subtracao();
                    break;
                case OperacaoCalculadora2.Divisao:
                    resultado = Divisao();
                    break;
                case OperacaoCalculadora2.Multiplicao:
                    resultado = Multiplicacao();
                    break;
            }

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