using SubmarinoDiagnostico.Domain;
using SubmarinoDiagnosticos.Infrastructure;

IInfrastructure infrastructure = new Infrastructure();
var listaNumerosBinarios = await infrastructure.ObterListaNumerosBinarios();

ISubmarinoDiagnostico submarinoDiagnostico = new SubmarinoDiagnostico.Domain.SubmarinoDiagnostico();
int consumoEnergia = await submarinoDiagnostico.CalcularConsumoEnergeticoAsync(listaNumerosBinarios);

if (consumoEnergia > 0)
{
    Console.WriteLine($"O consumo de energia do submarino é: {consumoEnergia}");
}
else
{
    Console.WriteLine($"Erro ao calcular o consumo de energia do submarino");
}
