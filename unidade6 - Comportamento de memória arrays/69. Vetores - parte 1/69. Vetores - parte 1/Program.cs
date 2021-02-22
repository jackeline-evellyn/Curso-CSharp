using System;
using System.Globalization;

namespace _69._Vetores___parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor Tipo Struct

            //Recebe o tamanho do vetor
            int tamanhoVetor = int.Parse(Console.ReadLine());

            double[] vetor= new double [tamanhoVetor];

            for(int i=0; i < tamanhoVetor; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int i =0; i<tamanhoVetor; i++)
            {
                soma += vetor[i];
            }

            double media = soma / tamanhoVetor;
            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
} 
