using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Euler_16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger x = new BigInteger();
            x = (BigInteger)Math.Pow(2, 1000);
            int result = 0;
            string k = x.ToString();
            for (int i = 0; i < k.Length; i++)
                result += (int)Char.GetNumericValue(k[i]);
            Console.WriteLine(result);
        }
    }
}
