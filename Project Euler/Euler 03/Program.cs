using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong bb = 600851475143; 
            ulong targ = 2;
            ulong x = 0;
            while ((targ * targ) < bb)
            {
                if ((bb % targ) == 0)
                {
                    Console.WriteLine(targ);
                    bb /= targ;
                }
                else
                    targ++;
            }
            if (bb != 1)
                Console.WriteLine( bb);
        }
    }
}
