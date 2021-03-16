using System;
using System.IO;

namespace _142._Bloco_finally
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.Write(line);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            //finally executa de toda forma
            finally
            {
               if(fs != null)
                {
                    fs.Close();
                }

            }
        }
    }
}
