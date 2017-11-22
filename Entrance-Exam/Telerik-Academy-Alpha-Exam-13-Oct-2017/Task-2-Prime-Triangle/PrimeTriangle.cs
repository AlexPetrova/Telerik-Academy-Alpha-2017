using System;
using System.Collections.Generic;

class PrimeTriangle
{
    static void Main()
    {
        int end = int.Parse(Console.ReadLine());

        List<int> numbers = FindPrimesNumbersInRange(0, end);

        int n = 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int k = 0; k < numbers[i]; k++)
            {
                if (numbers.Contains(n))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                n++;
            }
            n = 1;
            Console.WriteLine();
        }
    }
    public static bool PrimeNumberCheck(long num)
    {
        bool isPrime = true;
        int devider = 2;
        int maxDevider = (int)Math.Sqrt(num);

        if (num == 0 || num == 1 || num < 0)
        {
            isPrime = false;
            return isPrime;
        }

        while (devider <= maxDevider)
        {
            if (num % devider == 0)
            {
                isPrime = false;
                return isPrime;
            }

            devider++;
        }

        return isPrime;
    }
    static List<int> FindPrimesNumbersInRange(int startNum, int endNum)
    {
        List<int> primesInRange = new List<int>();
        primesInRange.Add(1); for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = PrimeNumberCheck(i);
            if (isPrime)
            {
                primesInRange.Add(i);
            }
        }
        return primesInRange;
    }
}
