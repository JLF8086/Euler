using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler_19
{
    class Program
    {
         
        static void Main(string[] args)
        {
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int weekday = 1;
            int result = 0;
            for (int i = 1901; i <= 2000; i++)
            {
                if (i % 4 == 0)
                    months[2] = 29;
                else
                    months[2] = 28;
                for (int j = 0; j < 12; j++)
                {
                    for (int k = 1; k <= months[j]; k++)
                        if ((k == 1) && (weekday == 7))
                            result++;
                    weekday = weekday == 7 ? weekday = 1 : ++weekday;
                }
            }

            sw.Stop();
            Console.WriteLine(result + " time elapsed: " + sw.Elapsed);
            

        }

    }
}
