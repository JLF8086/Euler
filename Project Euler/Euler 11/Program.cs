using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Euler_11
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader("data.txt");
            int [,] matrix = new int [20, 20];
            for (int i = 0; i < 20; i++)
            {
                string line = file.ReadLine();
                string[] z = line.Split(' ');
                for (int j = 0; j < 20; j++)
                    matrix[i, j] = Int32.Parse(z[j]);
            }
            ulong Product = 0;
            for(int i = 0; i < 20; i++)
            {
                int j = 0;
                while (j < 16)
                { 
                    if ((ulong)(matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3]) > Product)
                        Product = (ulong)(matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3]);
                    j++;
                }
            }
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 20; j++)
                    if ((ulong)(matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j]) > Product)
                        Product = (ulong)(matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j]);
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 16; j++)
                    if ((ulong)(matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3]) > Product)
                        Product = (ulong)(matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3]);
            for (int i = 3; i < 20; i++)
                for (int j = 0; j < 16; j++)
                    if ((ulong)(matrix[i, j] * matrix[i - 1, j + 1] * matrix[i - 2, j + 2] * matrix[i - 3, j + 3]) > Product)
                        Product = (ulong)(matrix[i, j] * matrix[i - 1, j + 1] * matrix[i - 2, j + 2] * matrix[i - 3, j + 3]);
            Console.WriteLine(Product);
        }
    }
}
