using System;
using _221.Delegates.Services;

namespace _221.Delegates
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);// operação numerica binaria 

        static void Main(string[] args)
        {
            /* É tipo referencia
             * Delegate pré definidos: action, func e predicate
             */

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculatorService.Max;
            //Possui type safety, se tentar passar um valor que nao retorne double
            //ou que nao seja dois valores ele dará erro no compilador e não na execução

            double result = op.Invoke(a, b); // invoke é opcional
            Console.WriteLine(result);


        }
    }
}
