using System;
using System.Globalization;

namespace _88.DateTime__data_e_hora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representa um instante
            //Tipo struct - tipo valor

            //Now - Horário atual
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            //Internamente é colocado o numero e Ticks (100 nanosegundos)
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            //Today- Dia atual com hora zerada
            DateTime d5 = DateTime.Today;

            //UtfNow - Horario no fuso horario de greenwich
            DateTime d6 = DateTime.UtcNow;

            //Parse - Recebe em formato de string
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            //ParseExact - Quando quer determinar o formato da data
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture );
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);



            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
