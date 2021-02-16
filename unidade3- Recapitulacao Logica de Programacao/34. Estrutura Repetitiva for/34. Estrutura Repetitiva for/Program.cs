using System;

namespace _34._Estrutura_Repetitiva_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usado quando se sabe antecipadamente a quantidade de repeticoes

            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}
