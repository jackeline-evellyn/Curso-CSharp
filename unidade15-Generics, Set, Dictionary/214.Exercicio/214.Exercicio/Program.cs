using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace _214.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> election = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string name = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (election.ContainsKey(name))
                        {
                            election[name] += votes;
                        }
                        else
                        {
                            election[name] = votes;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in election)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
