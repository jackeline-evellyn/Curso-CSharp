using System;
using System.IO;

namespace _189.StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stream capaz de escrever caracteres a parti de uma stream binária
            string sourcePath = @"c:\temp\file1.txt"; //arquivo de origem
            string targetPath = @"c:\temp\file2.txt"; //arquivo de destino

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
