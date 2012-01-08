using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 1000; a++)
                for (int b = a+1; b < 1000; b++)
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000)
                            if (Math.Sqrt(a * a + b * b) == c)
                            {
                                Console.WriteLine(a + " " + b + " " + c);
                                Console.WriteLine(a * b * c);
                                return;
                            }
                    }
        }
    }
}
