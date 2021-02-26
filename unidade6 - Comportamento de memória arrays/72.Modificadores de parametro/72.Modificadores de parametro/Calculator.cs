using System;
using System.Collections.Generic;
using System.Text;

namespace _72.Modificadores_de_parametro
{
    class Calculator
    {
        //Solução ruim para sobrecarga:
        /*
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        //Uma forma melhor
        public static int Sum(params int[] numbers) 
            // com params avisa ao compilador que é uma quantidade variavel de valores
        {
            int sum = 0;
            for (int i =0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        

    }
}
