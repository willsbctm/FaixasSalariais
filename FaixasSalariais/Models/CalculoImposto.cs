namespace FaixasSalariais.Models
{
    public class CalculoImposto
    {
        public readonly decimal Aliquota;
        public readonly decimal Porcentagem;

        public CalculoImposto(decimal aliquota, decimal porcentagem)
        {
            Aliquota = aliquota;
            Porcentagem = porcentagem;
        }

        public decimal Calcular(decimal salario)
        {
            return (salario + Aliquota) * Porcentagem;
        }
    }
}