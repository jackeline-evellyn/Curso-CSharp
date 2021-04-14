using System;
using _207.GetHashCode_Equals.Entities;

namespace _207.GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operações da classe object
            //GetHashCode: rápido, mas a pesar de raro pode trazer resposta errada (colisão de valores)
            //Equals: lenta, porém resposta correta 100%

            string a = "Maria";
            string b = "Alex";
            
            Console.WriteLine(a.Equals(b));


            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client ab = new Client{Name = "Maria", Email = "maria@gmail.com"};
            Client cd = new Client { Name = "Alex", Email = "maria@gmail.com"};
            
            Console.WriteLine();
            Console.WriteLine(ab.Equals(cd)); // compara o conteudo
            Console.WriteLine(ab == cd); // compara referencia do ponteiro de memoria do objeto
            Console.WriteLine(ab.GetHashCode());
            Console.WriteLine(cd.GetHashCode());

        
        
        }
    }
}
