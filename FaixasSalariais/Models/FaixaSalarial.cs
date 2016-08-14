namespace FaixasSalariais.Models
{
    public class FaixaSalarial
    {
        public readonly decimal Minimo;
        public readonly decimal Maximo;
        public readonly CalculoImposto Calculo;

        public FaixaSalarial(decimal minimo, decimal maximo, CalculoImposto calculo)
        {
            Minimo = minimo;
            Maximo = maximo;
            Calculo = calculo;
        }

        public bool EstaContidoNaFaixa(decimal salario)
        {
            return salario >= Minimo && salario < Maximo;
        }
    }
}