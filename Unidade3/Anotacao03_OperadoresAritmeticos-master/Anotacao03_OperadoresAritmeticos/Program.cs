using System;

namespace Anotacao03_OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8;
            double n5 = 10.0 / 8;
            //Dividindo 10/8  o valor ficará truncado, assim não gerando casas decimais.
            //É necessário declarar que é do tipo double ou colocar o .0


            //Formula de bhaskara
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4.0 * a * c;

            //A função Math.Pow realiza operações como ao quadrado, cubo..
             double delta2 = Math.Pow(b, 2.0) - 4.0 * a * c;
             double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine("O valor de delta é " +delta + " e o valor de x1 é "+x1 + "e o x2 é " +x2);
        }
    }
}
