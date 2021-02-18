using System;

namespace _54._Palavra_this
{
    class Program
    {
        static void Main(string[] args)
        {
            // A palavra this possui três funções

            //#1 Diferenciar atributos de variaveis locais
            //Não muito usado em C#, pois os atributos são colocados em letras minusculas
            //mas bastante usado em Java que não possui esse padrão
            //exemplo de uso

            /*
             public Produto (string Nome, double Preco){
                this.Nome = Nome;
                this.Preco = Preco;
                Quantidade = 0;
            }
             */


            //#2 : Quando vai refereciar outro construtor em um construtor
            //No caso irá reaproveitar o que é colcado no construtor padrão

            /*
            public Produto()
            {
                Quantidade = 0;
            } 
            //ele estará reaproveitando o Quantidade
            public Produto (string nome, double preco) : this(){ 
                Nome = nome;
                Preco = preco;
            }
            public Produto (string nome, double preco, int quantidade) : this(nome, preco){
                Quantidade = quantidade;
            }
            */

            //#3 Passar o próprio objeto como argumento na chamade de um método ou construtor
            /*
             class ChessMatch{
            
                PlaceNewPiece('e',1, new King(board, Color.White, this)); 
            //NEsse caso estará passando o proprio objeto
            }
             
             
             */
            
        }
    }
}
