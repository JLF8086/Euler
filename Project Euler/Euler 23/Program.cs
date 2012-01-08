using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> abundants = new List<int>();
            int result = 0;
            int[] numbers = new int[28123];

            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = i + 1;

                result += numbers[i];

                if (isAbundant(numbers[i]))
                {
                    abundants.Add(numbers[i]);
                }
            }
            

            for (int i = 0; i < abundants.Count(); i++)
            {
                for (int j = i; j < abundants.Count(); j++)
                {
                    int index = abundants[i] + abundants[j] - 1;

                    if (index < numbers.Count())
                    {
                        result -= numbers[index];
                        numbers[index] = 0;
                    }
                }
            }
            Console.WriteLine(result);
                    
                    
            
        }
        static bool isAbundant(int x)
        {
            int result = 0;
            for (int i = 1; i <= x/2; i++)
                if ((x % i) == 0)
                    result += i;
            if (result > x)
                return true;
            return false;
        }

        static bool notSummable(List<int> list, int x)
        {
            foreach (int j in list)
                foreach (int k in list)
                    if (j + k == x)
                        return false;
            return true;

        }
    }
}
