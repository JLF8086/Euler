using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_7
{


    class Program
    {
        static bool isPrime(int numb)
        {
            for (int i = numb / 2; i >= 2; i--)
            {
                if ((numb % i) == 0)
                    return false;
            }
            return true;

        }
        static int findNext(int numb)
        {
            while (true)
            {
                numb++;
                if (isPrime(numb))
                    return numb;
            }
        }

        static void Main(string[] args)
        {
            int x = 2;
            for (int i = 1; i < 10001; i++)
                x = findNext(x);
            Console.WriteLine(x);

        }
    }
}