using System;
using System.IO;
using System.Collections.Generic;

namespace _190.Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory, DirectoryInfo
            //Operações com pastas (create, enumerate, get files, etc)

            string path = @"c:\temp\myfolder";

            try
            {
                //1- Listar todas pastas
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                //2- Listar todos arquivos a partir de uma pasta
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //3- Criar uma pasta
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
