using FaixasSalariais.Models;
using FluentAssertions;
using Xunit;

namespace FaixasSalariais.Tests.Models
{
    public class CalculadoraImpostoTestes
    {
        [Fact]
        public void DeveCalcularValorImpostoParaPrimeiraFaixa()
        {
            var salario = 500;
            var calculadoraImposto = new CalculadoraImposto();
            var imposto = calculadoraImposto.Calcular(salario);

            imposto.Should().Be(0);
        }

        [Fact]
        public void DeveCalcularValorImpostoParaSegundaFaixa()
        {
            var salario = 1500;
            var calculadoraImposto = new CalculadoraImposto();
            var imposto = calculadoraImposto.Calcular(salario);

            imposto.Should().Be(90);
        }

        [Fact]
        public void DevaCalcularValorImpostoParaTerceiraFaixa()
        {
            var salario = 2000;
            var calculadoraImposto = new CalculadoraImposto();
            var imposto = calculadoraImposto.Calcular(salario);

            imposto.Should().Be(230);
        }
    }
}
