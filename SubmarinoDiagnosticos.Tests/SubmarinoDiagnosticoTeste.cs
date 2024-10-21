using FluentAssertions;
using SubmarinoDiagnostico.Domain;
using SubmarinoDiagnosticos.Infrastructure;
using Xunit;

namespace SubmarinoDiagnosticos.Tests
{
    public class SubmarinoDiagnosticoTeste
    {
        private readonly ISubmarinoDiagnostico _submarinoDiagnostico;

        public SubmarinoDiagnosticoTeste()
        {
            _submarinoDiagnostico = new SubmarinoDiagnostico.Domain.SubmarinoDiagnostico();
        }

        [Fact]
        public async void SubmarinoDiagnosticoTeste_CalcularConsumoEnergetico_Happypath_()
        {
            IInfrastructure infrastructure = new Infrastructure.Infrastructure();
            var listaNumerosBinarios = await infrastructure.ObterListaNumerosBinarios();

            int resultadoEsperado = 198;
            var resultado = await _submarinoDiagnostico.CalcularConsumoEnergeticoAsync(listaNumerosBinarios);

            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public async void SubmarinoDiagnosticoTeste_CalcularConsumoEnergetico_SemRegistros()
        {
            var numerosBinarios = new List<string>();

            int resultadoEsperado = 0;
            var resultado = await _submarinoDiagnostico.CalcularConsumoEnergeticoAsync(numerosBinarios);

            resultado.Should().Be(resultadoEsperado);
        }
    }
}
