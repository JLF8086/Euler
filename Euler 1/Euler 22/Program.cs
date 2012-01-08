using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Euler_22
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader("names.txt");
            string x = file.ReadLine();
            string[] names = x.Split(',');
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Replace("\"", "");   
            }
            Array.Sort(names); 
            long sum = 0;
            for (int i = 0; i < names.Length; i++)
                sum += (i + 1) * value(names[i]);
            Console.WriteLine(sum);
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "COLIN")
                    Console.WriteLine(i);
        }
        static long value(string str)
        {
            long result = 0;
            for (int i = 0; i < str.Length; i++)
                result += str[i]-64;
            return result;
        }
    }
}
