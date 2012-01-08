using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_15
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,] matrix = new long[21, 21];
            for (int i = 0; i < 21; i++)
            {
                matrix[0, i] = 1;
                matrix[i, 0] = 1;
            }
            for (int i = 1; i < 21; i++)
                for (int j = 1; j < 21; j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            Console.WriteLine(matrix[20, 20]);
        }
    }
}
