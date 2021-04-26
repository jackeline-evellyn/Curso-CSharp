using System;
using System.Linq;
using System.Collections.Generic;
namespace _226.Linq
{
    class Program
    {
        static void Main( string[] args)
        {
            //3 passos

            //1- Criar um data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //2- Definir a query
            var result = numbers.
                Where(x => x % 2 == 0).
                Select(x => x * 10);
               //Antes do ponto realiza uma operação
               //depois do ponto modifica o valor do resultado

            //3- Executar a query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
