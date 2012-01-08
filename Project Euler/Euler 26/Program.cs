using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int d = 1; d < 1000; d++)
            {
                Decimal numb = Decimal.Divide(1, d);
                string s = numb.ToString();
                s = s.Substring(s.IndexOf('.') + 1);
                Console.WriteLine(s);
                if (s.Equals("0013888888888888888888888889")) {
                    Console.WriteLine(d);
                    break;
                    
                }

            }
            
        }
    }
}
