using System;

namespace Cap6ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Matriz:");
            string[] linha = Console.ReadLine().Split(" ");
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

        }
    }
}
