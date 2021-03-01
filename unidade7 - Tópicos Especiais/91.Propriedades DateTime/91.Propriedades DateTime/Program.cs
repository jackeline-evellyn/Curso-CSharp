using System;

namespace _91.Propriedades_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Propriedades e Operações

            //Propriedades 
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime today =  DateTime.Now;

            Console.WriteLine(d);
            Console.WriteLine("--------------------");
            Console.WriteLine("Propriedades: pega uma parte do DateTime");
            Console.WriteLine("1) Date: "+today);
            Console.WriteLine("2) Day: "+ today.Day);
            Console.WriteLine("3) DayOfWeek: " + today.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + today.DayOfYear);
            Console.WriteLine("5) Hour: " + today.Hour);
            Console.WriteLine("6) Kind: " + today.Kind); //tipo: local ou universal
            Console.WriteLine("7) Millisecond: " + today.Millisecond);
            Console.WriteLine("8) Minute: " + today.Minute);
            Console.WriteLine("9) Month: " + today.Month);
            Console.WriteLine("10)Second: " + today.Second);
            Console.WriteLine("11)Ticks: " + today.Ticks);
            Console.WriteLine("12)TimeOfDay: " + today.TimeOfDay); // Horário do dia - TimeSpan
            Console.WriteLine("13)Year: " + today.Year);


            Console.WriteLine("----------------------------");
            Console.WriteLine("Formatação: Exibir do formato desejado");

            string s1 = today.ToLongTimeString();
            string s2 = today.ToShortDateString();
            string s3 = today.ToShortTimeString();
            string s4 = today.ToString();
            string s5 = today.ToString("yy-MM-dd HH:mm:ss");
            string s6 = today.ToString("yy-MM-dd HH:mm:ss.fff"); //fff - os milisegundos



            Console.WriteLine(today.ToLongDateString()); // converte em string, pega o formato do computador
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);

            //Operações
            Console.WriteLine("---------------------");
            Console.WriteLine("Operações: ");

            DateTime o = today;
            DateTime o1 = today.AddHours(2);
            DateTime o2 = today.AddMinutes(3);
            DateTime o3 = today.AddDays(7);

            Console.WriteLine("1) " + o);
            Console.WriteLine("2) " + o1 + " - Adicionar Horas");
            Console.WriteLine("3) " + o2 + " - Adicionar Minutos");
            Console.WriteLine("4) " + o3 + " - Adicionar Dias");


            //Diferença entre datas

            DateTime data1 = new DateTime(2000, 10, 15);
            DateTime data2 = new DateTime(2000, 10, 18);

            TimeSpan t = data2.Subtract(data1);

            Console.WriteLine(t);










        }
    }
}
