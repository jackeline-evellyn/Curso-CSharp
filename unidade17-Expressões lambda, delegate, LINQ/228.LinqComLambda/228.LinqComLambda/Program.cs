using System;
using _228.LinqComLambda.Entities;
using System.Collections.Generic;

namespace _228.LinqComLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 2, Name = "Eletronic", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){}

            };

        }
    }
}
