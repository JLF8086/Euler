using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler_20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numb = 1;
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                numb *= i;
            }
            while (numb > 0)
            {
                result += (int)(numb % 10);
                numb /= 10;
            }
            Console.WriteLine(result);
        }

    }
}
