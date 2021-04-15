using System;
using System.Collections.Generic;

namespace _208.Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conjuntos:
             * não permitem repetições
             * Não possuem posição
             * Rápida inserção, união e diferença
             
            - HashSet<T> 
                - Armazenamento em Hash
                - Extremamente rápido: Inserção, remoção e busca
                - A ordem dos elementos não é garantida

             - SortedSet<T>
                - Armazenamento em árvore
                - Rápido: inserção, remoção e busca
                - Elementos armazenados ordenadamente conforme a implementação IComparer<T>
     
             */

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); //verifica se existe

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}
