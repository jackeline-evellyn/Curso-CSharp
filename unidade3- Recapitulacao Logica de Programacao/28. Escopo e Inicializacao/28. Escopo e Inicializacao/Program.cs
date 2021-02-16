using System;

namespace _28._Escopo_e_Inicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escopo de uma variavel é a regiao do programa onde uma variavel pode ser inicializada
            //Uma variavel nao pode ser usada se nao for inicializada

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            if (preco > 100.0)
            {
                //Uma variavel declarada fora do escopo nao pode ser inicializada 
                //apenas pode ser usada dentro do if 
                //double desconto = preco * 0.1; 

                desconto = preco * 0.10;
            }
            Console.WriteLine(desconto);
        }
    }
}
