using System;

namespace _20._Conversao_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversao implicita VERSUS casting

            //Conversão implicita = Só possivel quando e colocado em uma variavel que suporta um valor maior

            float x = 4.5f;
            double y = x; // o double suporta mais que o float 



            //Casting, quando é convertido para um valor menor precisa deixar explicito

            double a;
            int b;

            a = 5.1;
            b = (int)a; // exemplo de casting

            Console.WriteLine(y);
            Console.WriteLine(b);

        }
    }
}
