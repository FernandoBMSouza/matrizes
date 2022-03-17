using System;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insira o tamanho da matriz N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(values[j]); 
                }
            }

            System.Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < n; i++)
            {
                System.Console.Write($"{matrix[i, i]} ");
            }
            
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(matrix[i,j] < 0) 
                        count++;
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Negative Numbers: {count}");
        }
    }
}