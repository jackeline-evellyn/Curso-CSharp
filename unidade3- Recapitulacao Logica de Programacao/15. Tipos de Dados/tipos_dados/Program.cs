using System;

namespace tipos_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alguns dos tipos possíveis de dados no C# abaixo:

            sbyte x = 100;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            //Use o L no final do valor para explicitar que é uma variavel longa
            float n5 = 4.5f;
            //coloca-se o F para indicar que é o tipo float
            double n6 = 4.5;
            string nome = "Maria";
            //Para Representar literalmente uma String é necessário usar aspas duplas
            object obj1 = "Alex Brown";
            object obj2 = "4.5";
            //object aceita qualquer coisa

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(x);

            //Não é necessário decorar o valor minimo e maximo possível de cada variável
            // É possível identificar pelo próprio programa

            int n10 = int.MinValue;
            int n11 = int.MaxValue;
            sbyte n12 = sbyte.MinValue;
            decimal n13 = decimal.MaxValue;

            Console.WriteLine("Valores ");
            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(n12);
            Console.WriteLine(n13);
        }
    }
}
