using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_17
{
    class Program
    {
        static int[] numbers = { 4, 3, 3 , 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
        static int[] tens = { 0, 3, 6, 6, 5, 5, 5, 7, 6, 6 };
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 1000; i++)
                result += numberLength(i);
                Console.WriteLine(result);

        }

        static int numberLength(int numb)
        {
            if (numb > 1000)
                return 0;
            int result = 0;
            if (numb == 1000)
                return 11;
            if (numb > 99)
            {
                result += numbers[numb / 100] + 7;
                numb %= 100;
                if (numb > 0)
                    result += 3;
            }
            
            if (numb > 19)
            {
                try
                {
                    result += (tens[(numb / 10)]);
                }
                catch
                {
                    Console.WriteLine("luzta ant " + numb);
                }
                numb %= 10;
            }
                if (numb > 0)
                result += numbers[numb];
            return result;
        }
    }
}
