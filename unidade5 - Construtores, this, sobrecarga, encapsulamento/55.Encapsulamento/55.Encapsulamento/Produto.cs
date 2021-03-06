﻿using System.Globalization;

namespace _55.Encapsulamento
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
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome (string nome) //metodo void pois nao retorna nada
        {
            //a vantagem de usar encapsulamento é que pode colocar uma lógica

            if(nome != null && nome.Length> 1){
                _nome = nome; // recebe o nome colocado

            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
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