using System;
using System.Globalization;

namespace _32._Estrutura_Repeticao_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite Outro Número");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Número negativo");
        }
    }
}
