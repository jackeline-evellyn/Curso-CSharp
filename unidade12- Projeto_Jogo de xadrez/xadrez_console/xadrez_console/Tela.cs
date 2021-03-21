using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i<tab.linhas; i++)
            {
                Console.Write(8-i +" ");
                for(int j=0; j<tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    //Apenas imprime a peça
                    Console.Write(peca);
                }
                else
                {
                    //cria uma variavel auxiliar que recebe a cor original 
                    ConsoleColor aux = Console.ForegroundColor;
                    //altera para amarelo 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    //Retorna para a cor original
                    Console.ForegroundColor = aux;

                }
                Console.Write(" ");
            }
        }
        
    }
}
