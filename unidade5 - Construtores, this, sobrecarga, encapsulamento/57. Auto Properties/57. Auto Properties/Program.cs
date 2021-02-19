using System;
using System.Globalization;

namespace _57._Auto_Properties
{
    class Program
    {
        //propriedade auto implementadas
        // feito em propriedades que nao necessitam de logicas particulares
        //nas operações de get e set
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome = "TV";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
        }
    }
}
