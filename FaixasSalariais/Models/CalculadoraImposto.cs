using System.Collections.Generic;
using System.Linq;

namespace FaixasSalariais.Models
{
    public class CalculadoraImposto
    {
        private List<FaixaSalarial> faixas;

        public CalculadoraImposto()
        {
            faixas = new List<FaixaSalarial> {
                    new FaixaSalarial(0, 600, new CalculoImposto(0, 0)),
                    new FaixaSalarial(600, 2000, new CalculoImposto(300, 0.05M)),
                    new FaixaSalarial(2000, 3000, new CalculoImposto(300, 0.1M))
                };
        }

        public decimal Calcular(int salario)
        {
            return faixas
                .FirstOrDefault(x => x.EstaContidoNaFaixa(salario))
                .Calculo.Calcular(salario);
        }
    }
}