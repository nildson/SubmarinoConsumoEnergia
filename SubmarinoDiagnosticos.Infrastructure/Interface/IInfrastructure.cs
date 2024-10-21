namespace SubmarinoDiagnosticos.Infrastructure
{
    public interface IInfrastructure
    {
        Task<List<string>> ObterListaNumerosBinarios();
    }
}
