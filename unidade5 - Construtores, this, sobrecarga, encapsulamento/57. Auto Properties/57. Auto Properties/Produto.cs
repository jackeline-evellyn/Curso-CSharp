using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _57._Auto_Properties
{
    class Produto
    {
        private string _nome; 
        public double Preco { get; private set; } // autoproperties
        public int Quantidade { get; private set; }

        //atalho "prop" tab tab 
        //monta a estrutura
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Properties são definições de métodos encapsulados
       
        //No nome não pode ser usado auto properties
        //pois possui uma lógica particular
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}