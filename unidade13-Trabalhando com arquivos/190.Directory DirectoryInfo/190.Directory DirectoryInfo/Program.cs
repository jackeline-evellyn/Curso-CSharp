using System;
using System.IO;
using System.Collections.Generic;

namespace _190.Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
