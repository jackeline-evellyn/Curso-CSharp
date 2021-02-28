using System;

namespace _85.Inferencia_de_tipo_var
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inferir variavel - deduzir
            //ou seja, coloca "var" e será deduzido o tipo da variavel
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
