using System;
using System.Globalization;

namespace _51.Construtores
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
            Console.Write("Quantidade de Produtos: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco, quantidade);
            // gracas ao construtor é obrigatorio passar os dados

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
