using System;

namespace _75.Laco_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe para percorrer coleções

            string[] vect = new string[] { "Maria", "Bob", "Alex" };


            for(int i =0; i< vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("------------");
            foreach (string obj in vect){ // obj é o apelido
                Console.WriteLine(obj);

            }

        }
    }
}
