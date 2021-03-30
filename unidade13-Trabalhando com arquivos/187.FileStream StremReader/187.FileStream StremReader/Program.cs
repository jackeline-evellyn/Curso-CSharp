using System;
using System.IO;

namespace _187.FileStream_StremReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileStream -> Uma stream associada a um arquivo permite operação de leitura e escrita.
            suporte a dados binários.

            StreamReader -> Iniciado a partir do FileStream. Suporte a dados no formato de texto.
            */


            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream) // para ler todas linhas
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally 
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
