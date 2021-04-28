using System;
using System.Globalization;
using System.Linq;
using _231.LinqSimilarSQL.Entities;
using System.Collections.Generic;

namespace _231.LinqSimilarSQL
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 2, Name = "Eletronic", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id= 1, Name= "Computer", Price= 1100.0, Category= c2 },
                new Product(){Id= 2, Name= "Hammer", Price= 90.0, Category= c1 },
                new Product(){Id= 3, Name= "TV", Price= 1700.0, Category= c3 },
                new Product(){Id= 4, Name= "Notebook", Price= 1300.0, Category= c2 },
                new Product(){Id= 5, Name= "Saw", Price= 80.0, Category= c1 },
                new Product(){Id= 6, Name= "Tablet", Price= 700.00, Category= c2 },
                new Product(){Id= 7, Name= "Camera", Price= 700.00, Category= c3 },
                new Product(){Id= 8, Name= "Printer", Price= 350.0, Category= c3 },
                new Product(){Id= 9, Name= "Macbook", Price= 1800.00, Category= c2 },
                new Product(){Id= 10, Name= "Sound Bar", Price= 700.0, Category= c3 },
                new Product(){Id= 11, Name= "Level", Price= 70.0, Category= c1 },


                };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("Tier 1 AND Price < 900", r1);


            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAME OF PROUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name //ordem inversa de ordernação
                orderby p.Price // será ordenado primeiro por preço e depois por nome
                select p;


            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4); //Pula dois elementos e pega 4 
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4); 
            //faz a expressão normal similar ap sql 
            //depois coloca-se o terminador necessário
            
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //var r6 = products.First();
            var r6 = (from p in products select p).First(); // Nesse caso é um esforço denecessário
            Console.WriteLine("First test1: " + r6);
            //First caso nulo pode gerar uma exceção

            //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            var r7 =
                (from p in products
                 where p.Price > 3000
                 select p).FirstOrDefault();
            //também é um esforço desnecessário
            Console.WriteLine("First or Default test2: " + r7);
            //First or default caso nao tenha nenhum resultado retorna default
            Console.WriteLine();


            //Agrupar
            //var r17 = products.GroupBy(p => p.Category);

            var r17 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }


        }


    }
}
