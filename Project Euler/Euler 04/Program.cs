using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_4
{
    class Program
    {
        static bool isPal(string numb)
        {
            for (int i = 0; i < (numb.Length / 2); i++)
            {
                try
                {
                    if (numb[0 + i] != numb[numb.Length - 1 - i])
                        return false;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
             }
            return true;
        }
        static void Main(string[] args)
        {   
            int max = 0;
            for (int i = 100; i < 999; i ++)
                for (int j = 100; j < 999; j++)
                {
                    if (isPal(Convert.ToString(i * j)))
                        if ((i * j) > max)
                            max = (i * j);
                }
            Console.WriteLine(max);
        }
    }
}
