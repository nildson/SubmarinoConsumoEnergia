
namespace SubmarinoDiagnostico.Domain
{
    public interface ISubmarinoDiagnostico
    {
        Task<int> CalcularConsumoEnergeticoAsync(List<string> numerosBinarios);
    }
}
