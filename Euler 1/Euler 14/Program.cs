using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxcount = 0;
            int maxnumb = 0;
            for (int i = 0; i <= 1000000; i++)
            {
                int counter = 0;
                ulong current = (ulong) i;
                while (current > 1)
                {
                    if ((current % 2) == 0)
                        current = current / 2;
                    else current = current * 3 + 1;
                    counter++;
                }
                if (counter > maxcount)
                {
                    maxnumb = i;
                    maxcount = counter;
                }

            }
            Console.WriteLine(maxnumb + " " + maxcount);
        }
    }
}
