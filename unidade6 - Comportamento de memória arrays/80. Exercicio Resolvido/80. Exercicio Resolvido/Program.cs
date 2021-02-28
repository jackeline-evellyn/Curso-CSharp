using System;

namespace _80._Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double[,] mat = new double[num, num];

            for(int i =0; i < num; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j<num; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Diagonal Principal 
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < num; i++)
            {
                    Console.Write(mat[i,i]+ " "); 
            }
            Console.WriteLine();

            int count = 0;
            for(int i =0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++; 
                    }
                }
            }
            Console.WriteLine("Negative number: " + count);


        }
    }
}
