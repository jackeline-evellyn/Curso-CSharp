using System;
using System.Collections.Generic;

namespace _77._List_listas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Add - adiciona na sequencia
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");


            //Insert - possível especificar qual a posição
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Count - quantidade de itens na lista
            Console.WriteLine("List count: " + list.Count);

            //list.Find e list.Last - Encontrar um item que satisfaça o predicado
            string s1 = list.Find(Test);
            // preficado fica entre os parentes e é uma função
            Console.WriteLine("Fist A: " +  s1);

            //É possível fazer essa mesma função atraves de uma função lambda
            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s2);

            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s3);

            //Encontrar a primeira e a última POSIÇÃO da lista que satisfaça o predicado
            int posicao = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' " + posicao);

            int posicao2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A' " + posicao2);

            //list.FindLastIndex - Filtrar lista com base no predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------");

            //Remover itens da lista: Remove, RemoveAll, RemoveAt, RemoveRange
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //RemoveAll- Remove conforme o predicado
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //RemoveAt - remove conforme a posicao
            list.RemoveAt(1);
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Add("Luana");
            list.Add("Giovana");
            list.Add("Guilherme");

            //RemoveRange - remove uma faixa
            //posicao, quantidade a ser removido
            list.RemoveRange(2, 2); 
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
