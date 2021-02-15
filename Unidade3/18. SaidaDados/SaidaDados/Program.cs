using System;
using System.Globalization; //para usar o CultureInfo para alterar a formatação

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.35784;
            string nome = "Maria";
            int idade = 20;
            
            //Write escreve na mesma linha
            Console.Write("Bom dia!");
            //Com WriteLine existe quebra de linha
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("_______________________");
            //.ToString exibe com 2 casas decimais
            Console.WriteLine(saldo.ToString("F2")); // duas casas decimais
            Console.WriteLine(saldo.ToString("F4"));
            //Com Culture.InvariantCulture o separador é colocado o ponto. Para isso é necessário no inicio
            //do documento criar o using System.Globalization
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("_____________________");
            Console.WriteLine("Placeholders, Concatenação e Interpolação");
            Console.WriteLine("Placeholders: {0} tem {1} anos e saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"Interpolação: {nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine("Concatenação: " + nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais");
        }
    }
}

