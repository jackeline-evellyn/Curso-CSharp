using System;
using System.Globalization;

namespace _53._Sintaxe_alternativa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco);
            // gracas ao construtor é obrigatorio passar os dados
            Produto produto1 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 10};

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.AdicionarProdutos(qtd);

            Console.WriteLine("Dados atualizados: " + produto);
            Console.Write("Digite o número de produtos a ser removido no estoque: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}
