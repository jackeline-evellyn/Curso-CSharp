using System;
using System.Collections.Generic;
using System.Text;

namespace _210.Hash_Igualdade.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product)) //testa se o obj também é um Produto
            {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);

        }
    }
}
