using System;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o número de linhas: ");
            int m = int.Parse(Console.ReadLine());
            System.Console.Write("Insira o número de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            System.Console.WriteLine();
            System.Console.Write("Insira o valor da checagem: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i, j] == x)
                    {
                        System.Console.WriteLine($"Position {i}, {j}:");
                        System.Console.WriteLine($"Left: {mat[i, j - 1]}");
                        System.Console.WriteLine($"Right: {mat[i, j + 1]}");
                        System.Console.WriteLine($"Up: {mat[i - 1, j]}");
                        System.Console.WriteLine($"Down: {mat[i + 1, j]}");
                    }
                }
            }
        }
    }
}