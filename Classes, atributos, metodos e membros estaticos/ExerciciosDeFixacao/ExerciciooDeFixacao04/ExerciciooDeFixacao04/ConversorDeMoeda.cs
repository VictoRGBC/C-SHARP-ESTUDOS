using System;
using System.Globalization;

namespace ExerciciooDeFixacao04
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double DolarParaReal(double valorEmDolar, double cotacaoDolar)
        {
            double valorEmReais = valorEmDolar * cotacaoDolar;
            return valorEmReais + valorEmDolar * cotacaoDolar * (Iof / 100);
        }
    }
}