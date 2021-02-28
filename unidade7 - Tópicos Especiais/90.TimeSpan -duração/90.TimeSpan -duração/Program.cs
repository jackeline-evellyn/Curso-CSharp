using System;

namespace _81.TimeSpan__duracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan - duração
            //Também em forma de Ticks

            //TimeSpan passando hora minuto e segundo
            TimeSpan t1 = new TimeSpan(0, 1, 30); //hora minuto segundo

            //TimeSpan vazio- 0:00:00
            TimeSpan t2 = new TimeSpan();

            //TimeSpan passando a quantidade de Ticks
            TimeSpan t3 = new TimeSpan(9000000000L); // letra L para identificar que é um long

            //TimeSpan com dia, hora, minutos e segundos
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

            //TimeSpan com dia, hora, minutos, segundos e milisegundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            //TimeSpan equivalente a dias, horas
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            {

            }
        }
    }
}
