using System;
using System.Globalization;
using System.IO;
using _192.Exercicios.Entities;

namespace _192.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(path);

                string sourceFolderPath = Path.GetDirectoryName(path);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);
                        sw.WriteLine(product.Name + ", " + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
