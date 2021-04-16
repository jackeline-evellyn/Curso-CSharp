using System;

namespace _217.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021,04, 16, 8, 10, 45);

            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
