using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
namespace Euler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, normsum = 0;
            for (int i = 1; i <= 100; i++)
            {
                normsum += i;
                sum += i * i;
            }
            Console.WriteLine(normsum * normsum - sum);
        }
    }
}
