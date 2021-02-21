using System;

namespace _66.Tipos_referencia_e_tipos_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; //No tipo struct nao é necessario colocar
            // " = new Point ();
            p.X = 10; // é necessário inicializar
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point(); // No entanto ele pode receber o valor de new
            Console.WriteLine(p);
        }
    }
}
