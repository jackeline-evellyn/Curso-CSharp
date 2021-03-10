using System;
using System.Globalization;
using System.Collections.Generic;
using _137.Exercicios_propostos.Entities;

namespace _137.Exercicios_propostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(name, anualIncome, health));

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(name, anualIncome, employee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");  
            foreach(Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.Nome +": $ " + pessoa.CalculoImpostos().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
