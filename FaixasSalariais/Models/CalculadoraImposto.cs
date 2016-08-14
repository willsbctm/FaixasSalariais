namespace FaixasSalariais.Models
{
    public class CalculadoraImposto
    {
        public decimal Calcular(int salario)
        {
            return new FaixaSalarialUm()
                .DefinirFaixa(salario).Calculo.Calcular(salario);
        }
    }
}