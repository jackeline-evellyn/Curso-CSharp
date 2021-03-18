using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Posicao p;
            p = new Posicao(3, 4);
            Console.WriteLine("Posicao: " + p);

            Tela.imprimirTabuleiro(tab);

        }
    }
}
