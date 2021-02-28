using System;
using System.Globalization;

namespace _87.Sintaxe_Alternativa___ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //alternativa ao if else
            //sintaxe: (condicao) ? valor_se_verdadeiro : valor_se_falso

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            /*
             double desconto;

            if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */

            
            double desconto = (preco < 20.0) ? (preco * 0.1) : (preco * 0.05);
            Console.WriteLine(desconto);
        }
    }
}
