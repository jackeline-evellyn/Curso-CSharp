using System;

namespace _74._boxing_e_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing e Unboxing

            //Boxing
            //Conversão objeto tipo valor em objeto tipo referencia
            // objeto tipo valor -> tipo referencia

            int x = 20;
            Object obj = x;


            //Unboxing

            int y = 20;
            Object objeto = y;

            int z = (int)objeto;
            Console.WriteLine(z);
        }
    }
}
