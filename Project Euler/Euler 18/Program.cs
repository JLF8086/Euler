using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Euler_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineCount = File.ReadAllLines("data2.txt").Length;

            int[][] triangle = new int[lineCount][];
            TextReader file = new StreamReader("data2.txt");
            string line;
            int trHeight = 0;
            while ((line = file.ReadLine()) != null)
            {
                string[] arr = line.Split(' ');
                triangle [trHeight] = arr.Select(p => int.Parse(p)).ToArray();
                trHeight++;
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(triangle[i][j] + " ");
                Console.WriteLine();
            }
            for (int i = 1; i < triangle.Length; i++)
            {
                triangle[i][0] += triangle[i - 1][0];
                triangle[i][triangle[i].Length - 1] += triangle[i - 1][triangle[i - 1].Length - 1];
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] += Math.Max(triangle[i - 1][j], triangle[i - 1][j - 1]);
                }
            }
            int max = 0;
            foreach (int n in triangle[triangle.Length - 1])
            {
                
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine(max);

        }

    }
}
