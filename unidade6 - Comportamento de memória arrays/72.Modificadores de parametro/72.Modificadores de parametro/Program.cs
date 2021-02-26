using System;

namespace _72.Modificadores_de_parametro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem params
            //int soma1 = Calculator.Sum(new int[] { 2, 3 });
            //int soma2 = Calculator.Sum(new int[] { 2, 4, 3 });

            int soma1 = Calculator.Sum(2, 3);
            int soma2 = Calculator.Sum(2, 4, 3);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
        }
    }
}
