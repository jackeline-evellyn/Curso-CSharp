using System;
using System.Collections.Generic;
using System.Text;

namespace _48.Exercicios_Propostos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantidade, double cotacao)
        {
            double resultado = quantidade * cotacao;
            return resultado + resultado *Iof / 100.0;
        }
    }
}
