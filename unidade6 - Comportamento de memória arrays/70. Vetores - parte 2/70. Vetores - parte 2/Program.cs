using System;
using System.Globalization;

namespace _70._Vetores___parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vetor tipo Classe

            int tamanhoVetor = int.Parse(Console.ReadLine());

            //criando o vetor
            Produto[] vetor= new Produto[tamanhoVetor]; 

            for (int i =0; i < tamanhoVetor; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                //A principal diferença entre Vetor tipo Struct e tipo Classe
                //É a necessidade de instanciar
                vetor[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for(int i = 0; i <tamanhoVetor; i++)
            {
                soma += vetor[i].Preco; // .Preco -> acessa o valor
            }
            double media = soma / tamanhoVetor;
            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
