using System;
using System.Globalization;

namespace _48.Exercicios_Propostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(quantidade, cotacao);
            Console.Write("Valor a ser pago em reais? " + resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
