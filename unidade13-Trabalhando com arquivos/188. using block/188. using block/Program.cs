using System;
using System.IO;

namespace _188._using_block
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe simplificada que garante que objetos IDisposable serão fechados

            string path = @"c:\temp\file1.txt";

            try
            {
                // (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {

                            string line = sr.ReadLine();
                            Console.WriteLine(line);

                        }
                    }
                //}

            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            }
   
        
    }
}
