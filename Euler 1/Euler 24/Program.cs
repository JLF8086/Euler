using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler_24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> availNums = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //List<string> availNums = new List<string> { "0", "1", "2"};
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(countPermut(999999, 10, 3628800, availNums));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            //Console.WriteLine(countPermut(5, 3, 6, availNums));
        }
        static string countPermut(int numb, int length, int diap, List<string> availNumbs)
        {
            int segLength = diap / length;
            
            if (length == 1)
                return availNumbs[0];
            int segment = diap / length;
            int whichSegment = 0;
            
            while (true)
            {
                whichSegment++;
                if ((segment * whichSegment) > numb)
                    break;
            }

            int newnumb = numb - ((whichSegment - 1) * segment);
            diap /= length;
            string addedNumb = availNumbs[whichSegment-1];
            availNumbs.Remove(addedNumb);
            return addedNumb + countPermut(newnumb, length - 1, diap, availNumbs);
        }
    }
}
