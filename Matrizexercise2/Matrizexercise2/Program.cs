using System;

namespace Matrizexercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lenght = Console.ReadLine().Split(' ');
            int m = int.Parse(lenght[0]);
            int n = int.Parse(lenght[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if (mat[i, j] == number)
                    {
                        Console.WriteLine($"Position {i},{j}");
                        if(j > 0)
                        {
                        Console.WriteLine($"Left {mat[i, j - 1]}");
                        }
                        if(j < n - 1)
                        {
                        Console.WriteLine($"Right {mat[i, j + 1]}");
                        }
                        if (i < n - 1)
                        {
                        Console.WriteLine($"Down {mat[i + 1 , j]}");
                        }
                        if(i > 0) 
                        {
                        Console.WriteLine($"Top {mat[i - 1 , j]}");
                        }
                    } 
                }
            }
        }
    }
}
