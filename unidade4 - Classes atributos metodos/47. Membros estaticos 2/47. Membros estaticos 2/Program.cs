using System;
using System.Globalization;

namespace _47._Membros_estaticos_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circunferencia: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
