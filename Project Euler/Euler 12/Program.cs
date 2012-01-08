using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                n++;
                int divors;
                
                if ((n % 2) == 0)
                    divors = Divisors(n + 1) * Divisors(n / 2);
                else
                    divors = Divisors((n + 1) / 2) * Divisors(n);
                if (divors > 500)
                {
                    Console.WriteLine((n % 2) == 0 ? (n / 2) * (n + 1) : ((n + 1) / 2) * n);
                    break;
                }

                
                
            }

        }
        static int Divisors(int numb)
        {
            int result = 2;
            for (int i = numb / 2; i > 1; i--)
                if ((numb % i) == 0)
                    result++;
            return result;
        }
        
    }

}
