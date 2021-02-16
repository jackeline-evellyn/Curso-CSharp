using System;

namespace _27._Estrutura_condicional_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura condicional simples");
            int x = 2;
            if (x < 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Estrutura condicional composta");
            Console.WriteLine("Entre com um número inteiro");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Estrura condicional com encadeamento");
            Console.WriteLine("Qual a hora atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
