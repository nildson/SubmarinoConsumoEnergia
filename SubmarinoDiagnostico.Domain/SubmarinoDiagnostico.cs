using SubmarinoDiagnosticos.Domain;

namespace SubmarinoDiagnostico.Domain
{
    public class SubmarinoDiagnostico : ISubmarinoDiagnostico
    {
        const char indicadorGama = '1';
        
        public async Task<int> CalcularConsumoEnergeticoAsync(List<string> numerosBinarios)
        {
            int quantidadeBinarios = numerosBinarios.Count;

            if (quantidadeBinarios == 0)
            {
                return 0;
            }

            int quantidadeCaracteres = numerosBinarios[0].Length;
                        
            int[,] contadorBinario = ContarBinariosPorPosicao(numerosBinarios, quantidadeCaracteres);

            string taxaGama = "";
            string taxaEpsilon = "";
                        
            for (int i = 0; i < quantidadeCaracteres; i++)
            {
                if (contadorBinario[i, 1] > contadorBinario[i, 0])
                {
                    taxaGama += "1";
                    taxaEpsilon += "0";
                }
                else
                {
                    taxaGama += "0";
                    taxaEpsilon += "1";
                }
            }
                        
            int taxaGamaDecimal = ConversorBase.ConverterBinarioEmDecimal(taxaGama);
            int taxaEpsilonDecimal = ConversorBase.ConverterBinarioEmDecimal(taxaEpsilon);
                        
            return taxaGamaDecimal * taxaEpsilonDecimal;
        }

        private static int[,] ContarBinariosPorPosicao(List<string> numerosBinarios, int quantidadeCaracteres)
        {
            int[,] matrizContadorBinario = new int[quantidadeCaracteres, 2];

            foreach (var numero in numerosBinarios)
            {
                for (int i = 0; i < quantidadeCaracteres; i++)
                {
                    if (numero[i] == indicadorGama)
                    {
                        matrizContadorBinario[i, (int)EnumTipoPontuacao.PontuadorGama]++;
                    }
                    else
                    {
                        matrizContadorBinario[i, (int)EnumTipoPontuacao.PontuadorEpsilon]++;
                    }
                }
            }

            return matrizContadorBinario;
        }
    }
}
