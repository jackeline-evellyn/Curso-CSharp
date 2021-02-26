using System;

namespace _73.Modificadores_de_parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ref e Out- são considerados code smells ( design ruim)


            //Ref 
            int a = 10; //esse parametro precisa ser inicializado
            Calculator.Triple(ref a); // também é necessário indicar aqui que é uma referencia

            Console.WriteLine(a);

            //Out
            int b = 10;
            int triple; // de out nao precisa ser inicializado
            Calculator.Triplo(b, out triple);
            Console.WriteLine(triple);



        }
    }
}
