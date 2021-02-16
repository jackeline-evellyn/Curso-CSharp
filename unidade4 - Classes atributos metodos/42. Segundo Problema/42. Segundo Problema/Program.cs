using System;
using System.Globalization;

namespace _42._Segundo_Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qts = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(qts);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " +produto);

            Console.Write("Digite o número de produtos a ser removido no estoque: ");
            qts = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(qts);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);


        }
    }
}
