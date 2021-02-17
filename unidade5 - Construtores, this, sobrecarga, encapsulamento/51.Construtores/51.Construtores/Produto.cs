using System;
using System.Globalization;

namespace _51.Construtores
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //o construtor possui o mesmo nome da classe
        //o que é colocado entre o parentese obriga a ser colocado
        public Produto (string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + " ,$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        } 
    }
}
