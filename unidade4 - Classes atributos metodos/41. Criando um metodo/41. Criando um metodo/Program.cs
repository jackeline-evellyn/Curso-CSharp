using System;
using System.Globalization;

namespace _41._Criando_um_metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; // inicia duas variveis da classe triagulo

            x = new Triangulo(); // é necessario instanciar a classe
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("A área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine(" O maior triangulo é o X");
            }
            else
            {
                Console.WriteLine("O maior triangulo é o Y");
            }
        }
    }
}