using System;
using System.Collections.Generic;

namespace _213.Dictionary_SortedDictionary
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Em outras linguagens está como map
            Dictionary<TKey, TValue>
            - Não admite repetições na chave
            - Os elementos são indexados pelo objeto chave (não possuem posição)
            - Acesso, inserção e remoão são rápidos

             Dictionary
                - Armazenamento em tabela hash
                - Extremamente rápido: inserção, remoção e busca
                - A ordem dos elementos não é garatida

            SortedDictionary
                - Armazenamento em árvore
                - Rápido: inserção, remoção e busca
                - Os elementos são arazenados ordenadamente conforme implementação IComparer<T>
             */

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388"; // apenas subscreverá o valor

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }
            Console.WriteLine();

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies)
          //foreach (var item in cookies)
            {
                    Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
