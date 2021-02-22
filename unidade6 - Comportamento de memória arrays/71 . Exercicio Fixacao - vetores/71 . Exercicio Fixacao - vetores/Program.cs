using System;
using System.Globalization;

namespace _71_._Exercicio_Fixacao___vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented");
            int quartosAlugados = int.Parse(Console.ReadLine());

            Quarto[] quartos = new Quarto[10];

            for(int i = 0; i < quartosAlugados; i++)
            {
                Console.WriteLine("Rent #"+ (i+1));
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int nQuarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                quartos[nQuarto] = new Quarto { Nome = nome, Email = email };
            }
            for (int i =0; i<10; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine( i + ": "+ quartos[i].Nome + ", " + quartos[i].Email);
                }
            }
        }
    }
}
