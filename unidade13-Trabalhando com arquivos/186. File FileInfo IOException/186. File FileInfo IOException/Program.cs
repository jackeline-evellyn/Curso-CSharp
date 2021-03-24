using System;
using System.IO;

namespace _186._File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows.old\WINDOWS\Temp\file1.txt";
            string targetPath = @"C:\Windows.old\WINDOWS\Temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
