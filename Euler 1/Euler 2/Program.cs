using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum, result = 0, x = 1, y = 1;
            for (long i = 1; i < 50; i++)
            {
                sum = x + y;
                if ((sum % 2) == 0)
                    result += sum;
                if (sum > 4000000)
                    break;
                x = y;
                y = sum;
                
            }
            Console.WriteLine(result);
        }
    }
}
