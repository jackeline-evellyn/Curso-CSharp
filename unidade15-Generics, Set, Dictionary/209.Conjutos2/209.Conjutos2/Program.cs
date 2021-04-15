using System;
using System.Collections.Generic;

namespace _209.Conjutos2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 10, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);
            PrintCollection(b);

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); // união de c com b
            PrintCollection(c);


            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);


            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
             }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj  + " ");
            }
            Console.WriteLine( );
        }
    }
}
