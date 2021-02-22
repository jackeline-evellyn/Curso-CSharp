using System;

namespace _68.Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable: É um recurso para qe dados tipo valor (struct)
            //Possam receber o valor null, ou seja, terem seus campos como opcionais

            //double x = null; //erro, struct nao pode ser nulo

            Nullable<double> w= null;

            //Uma forma mais simples:
            double? x= null; // é do tipo double, mas opcional
            double? y = 10.0;
            /*
             Nullable possui 3 operações
                1- GetValueOrDefault
                2- HasValue
                3- Value - caso nulo, abre uma exceção 
             */

            //1- GetValueOrDefault:
            //Pega o valor ou o valor padrão do tipo
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //2- HasValue
            //Se existe algum valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //3- Value
            //Mostra o valor, caso nulo a operação quebra
            //Console.WriteLine(x.Value); 
            Console.WriteLine(y.Value);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }


            //Operador de colescência nula
            //Caso o primeiro valor seja nulo, recebe o segundo valor

            double? a = null;
            double b = a ?? 5.0; //ou seja, caso a seja null, recebe 5.0
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
