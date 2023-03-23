using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            double cotacaoDolar, qtdeDolar, resultado;

            //Entrada de Dados - Dólar
            Console.Write("Digite a cotação atual do dólar: ");
            cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade de dólar que irá comprar: ");
            qtdeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saída de Dados - Resultado
            resultado = ConverterMoeda.DolarParaReal(cotacaoDolar, qtdeDolar);
            Console.WriteLine("Valor a ser pago em reais: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
