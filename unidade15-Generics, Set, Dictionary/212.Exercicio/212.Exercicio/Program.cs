using System;
using System.Collections.Generic;

namespace _212.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();


            Console.Write("How many students for A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            Console.Write("How many students for B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }

            Console.Write("How many students for C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
