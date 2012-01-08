using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Numerics;

namespace Euler_13
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader("data.txt");
            string line;
            BigInteger sum = new BigInteger(0);
            while ((line = file.ReadLine()) != null)
            {
                sum += BigInteger.Parse(line);
            }
            
            while (sum > 10000000000)
                sum /= 10;
            Console.WriteLine(sum);
        }
    }
}
