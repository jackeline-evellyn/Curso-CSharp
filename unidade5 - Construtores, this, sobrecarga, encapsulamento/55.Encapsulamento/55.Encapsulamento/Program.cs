using System;
using System.Globalization;

namespace _55.Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Encapsulamento é esconder partes da implementação deixando apenas
             * operações seguras que mantenham em estado conscistente
             * Ou seja, disponibilizar ao usuário apenas as operações básicas
            */
            Produto produto = new Produto("TV", 500.00, 10);

            produto.SetNome("TV 4K");
            Console.WriteLine(produto.GetNome()) ;
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());


            
        }
    }
}