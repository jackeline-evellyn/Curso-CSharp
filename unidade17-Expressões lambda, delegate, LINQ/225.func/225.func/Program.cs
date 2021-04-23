using System;
using System.Collections.Generic;
using _225.func.Entities;
using System.Linq;
namespace _225.func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

         
            List<string> result = list.Select(NameUpper).ToList();
            //função select retorna em Enumerable
            //com .toList() é convertido para lista

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
    
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}
