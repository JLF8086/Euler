using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler_25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger prevTerm = 1;
            BigInteger currTerm = 1;
            int termCount = 2;
            while (true)
            {
                termCount++;
                BigInteger temp = prevTerm;
                prevTerm = currTerm;
                currTerm = prevTerm + temp;
                if (currTerm.ToString().Length == 1000)
                {
                    Console.WriteLine(termCount);
                    break;
                }
            }
        }

    }
}
