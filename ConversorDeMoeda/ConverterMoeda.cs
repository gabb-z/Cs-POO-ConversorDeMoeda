using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class ConverterMoeda
    {
        //Valor Estático
        public static double Iof = 6.0;

        //Função de Conversão - Estática
        public static double DolarParaReal(double cotacao, double quantidade)
        {
            double resultado = cotacao * quantidade;
            return resultado += Iof * cotacao * quantidade / 100.0;
        }
    }
}
