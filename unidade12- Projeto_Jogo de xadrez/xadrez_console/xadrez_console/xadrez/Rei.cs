using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;


namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            //verifica se o espaço é vazio ou a cor é diferente da peça que jogou
            return p == null || p.cor != this.cor;

        }

        public override string ToString()
        {
            return "R";
        }
         
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //verifica acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna +1 );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica sudeste
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica sudoeste
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica esquerda
            pos.definirValores(posicao.linha, posicao.coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //verifica noroeste
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }


    }
}
