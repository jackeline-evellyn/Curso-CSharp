using System;
using System.Globalization;
namespace _56._Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    */
            Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome= "TV 4K";
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());



        }
    }
}