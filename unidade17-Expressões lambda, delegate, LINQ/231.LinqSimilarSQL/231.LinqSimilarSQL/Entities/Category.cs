using System;
using System.Collections.Generic;
using System.Text;

namespace _231.LinqSimilarSQL.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; } // Tier é a pontuação 
    }
}
