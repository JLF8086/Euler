using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_10
{
    class Program
    {
        const int MAX = 1000000;

        static void Main(string[] args)
        {
            bool[] primes = new bool[MAX];
            for (int i = 0; i < MAX; i++)
                primes[i] = true;
            ulong sum = 0;
            for (int z = 2; z < primes.Length; z++)
            {
                if (primes[z] == true)
                {
                    sum += (ulong)z;
                    int tempSum = z;
                    while (tempSum < MAX)
                    {
                        tempSum += z;
                        if (tempSum < MAX) 
                        primes[tempSum] = false;
                    }
                }            
            }
            Console.WriteLine(sum);
            System.Diagnostics.Process.Start("Notepad.exe");
        }
    }
}
