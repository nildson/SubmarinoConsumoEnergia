namespace SubmarinoDiagnostico.Domain
{
    public class ConversorBase
    {
        public static int ConverterBinarioEmDecimal(string binario)
        {
            return Convert.ToInt32(binario, 2);
        }
    }
}
