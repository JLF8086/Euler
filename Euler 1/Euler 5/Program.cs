using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 20;
            bool finished = false;
            while (!finished)
            {
                finished = true;
                for (int i = 2; i < 20; i++)
                {
                    if (finished == true)
                        if (!((k % i) == 0))
                        {
                            finished = false;
                            break;
                        }
                }
                k++;
            }
            Console.WriteLine(k-1);
        }
    }
}
