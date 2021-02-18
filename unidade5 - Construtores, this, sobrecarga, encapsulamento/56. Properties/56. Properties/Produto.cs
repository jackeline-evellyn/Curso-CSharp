using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace _56._Properties
{
    class Produto
    {
        //Todos atributos devem ser private ( privativo da classe)
        private string _nome; // quando é private possui uma outra padronização de nome
        private double _preco; // underline e letra minuscula
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        //Properties são definições de métodos encapsulados
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        
        public double Preco
        {
            get { return _preco; }
        }
       public int Quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}