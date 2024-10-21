namespace SubmarinoDiagnosticos.Infrastructure
{
    public class Infrastructure : IInfrastructure
    {
        public async Task<List<string>> ObterListaNumerosBinarios()
        {
            var listaNumerosBinarios = new List<string>
            {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };

            return listaNumerosBinarios;
        }        
    }
}