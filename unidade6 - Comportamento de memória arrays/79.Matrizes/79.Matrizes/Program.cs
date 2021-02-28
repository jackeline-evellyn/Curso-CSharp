using System;

namespace _79.Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz - arranjo bidimensional
            double[,] mat = new double[2, 3];

            //Length, Rank, GetLength

            //Length: quantidade de elementos na matriz
            Console.WriteLine(mat.Length);

            //Rank: quantidade de linhas
            Console.WriteLine(mat.Rank);

            //GetLength: Primeira (0) e Segunda (1) dimensão
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));


        
        }
    }
}
