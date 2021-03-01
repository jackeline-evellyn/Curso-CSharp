using System; 

namespace _91.Propriedade_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Propriedades TimeSpan: ");
            TimeSpan t1 = TimeSpan.MaxValue; // Valor Maximo
            TimeSpan t2 = TimeSpan.MinValue; //Valor Minimo - recebe valor negativo
            TimeSpan t3 = TimeSpan.Zero; // Valor Zerado


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("-------------");
            Console.WriteLine("Retornam números inteiros");
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: "+ t.Ticks);

            Console.WriteLine("--------------");
            Console.WriteLine("Total - Coloca o valor completo");
            Console.WriteLine("Total Days: " + t.TotalDays);
            Console.WriteLine("Total Hours: " + t.TotalHours);
            Console.WriteLine("Total Minutes: "+ t.Minutes);
            Console.WriteLine("Total Seconds: " + t.Seconds);
            Console.WriteLine("Total Milliseconds: "+ t.Milliseconds);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Operações TimeSpan: ");

            TimeSpan d1 = new TimeSpan(1, 30, 10);
            TimeSpan d2 = new TimeSpan(0, 10, 5);
            
            TimeSpan sum = d1.Add(d2); // Soma
            TimeSpan dif = d1.Subtract(d2); //Diferença
            TimeSpan mult = d2.Multiply(2.0);
            TimeSpan div = d2.Divide(2.0);

            Console.WriteLine("1) Soma: " + sum);
            Console.WriteLine("2) Diferença: " + dif);
            Console.WriteLine("3) Multiplicação: " + mult);
            Console.WriteLine("4) Divisão: " + div);
        }
    }
}
