using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _42._Segundo_Problema
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString() //override sub escreve os valores
        {
            return Nome + " , $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +" ,"
                + Quantidade
                + " unidades, Total $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantidade) //funcao void nao retorna nada
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }
    }
}
