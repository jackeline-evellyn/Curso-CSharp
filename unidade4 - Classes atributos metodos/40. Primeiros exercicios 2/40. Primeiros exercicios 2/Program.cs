using System;
using System.Globalization;

namespace _40._Primeiros_exercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.WriteLine("Salario medio = "+ salarioMedio.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
