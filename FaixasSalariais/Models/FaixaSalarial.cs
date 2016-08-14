namespace FaixasSalariais.Models
{
    public abstract class FaixaSalarial
    {
        public readonly decimal Minimo;
        public readonly decimal? Maximo;
        public readonly CalculoImposto Calculo;
        public readonly FaixaSalarial Proximo;
        public FaixaSalarial(FaixaSalarial proximo, decimal minimo, decimal? maximo, CalculoImposto calculo)
        {
            Minimo = minimo;
            Maximo = maximo;
            Calculo = calculo;
            Proximo = proximo;
        }

        public FaixaSalarial DefinirFaixa(decimal salario)
        {
            if (salario >= Minimo && salario < Maximo)
                return this;

            return Proximo.DefinirFaixa(salario);
        }
    }

    public class FaixaSalarialUm : FaixaSalarial
    {
        public FaixaSalarialUm()
            : base(new FaixaSalarialDois(), 0, 600, new CalculoImposto(0, 0))
        {
        }
    }

    public class FaixaSalarialDois : FaixaSalarial
    {
        public FaixaSalarialDois()
            : base(new FaixaSalarialTres(), 600, 2000, new CalculoImposto(300, 0.05M))
        {
        }
    }

    public class FaixaSalarialTres : FaixaSalarial
    {
        public FaixaSalarialTres()
            : base(null, 2000, 3000, new CalculoImposto(300, 0.1M))
        {
        }
    }
}