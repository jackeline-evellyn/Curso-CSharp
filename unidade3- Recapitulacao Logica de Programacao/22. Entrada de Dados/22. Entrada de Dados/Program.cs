using System;

namespace _22._Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de Dados = quando o programa vai ler os dados que o usuário digitou 

            string frase = Console.ReadLine(); // Console.ReadLine é o comando para receber os dados
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

        

            Console.WriteLine("Você digitou");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            //Comando Split = recorta a string em varios pedaços

            string s = Console.ReadLine();

            string[] vetor = s.Split(' '); //recortara o s com base no espaço em branco

            //Maneira mais simplificada
            //string[] v = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
