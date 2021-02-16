using System;

namespace _26._Operadores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //operador e (&&)
            bool c1 = 2 > 3 && 4 != 5; //false
            Console.WriteLine(c1);

            //operador ou (!!)
            bool c2 = 2 > 3 || 4 != 5; //true
            Console.WriteLine(c2);

            //operador não (!)
            bool c3 = !(2 > 3) && 4 != 5; //true
            Console.WriteLine(c3);

            Console.WriteLine("--------------------");

            bool c4 = 10 < 5; //false
            bool c5 = c2 || c3 && c4;
            Console.WriteLine(c5);




        }
    }
}
