using System;
using System.Collections.Generic;
using System.Linq;

class Hops
{
    static void Main()
    {
        int[] field = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int n = int.Parse(Console.ReadLine());

        HashSet<int> stepedOn = new HashSet<int>();
        List<int> maxSetOfCarrots = new List<int>();

        int eatenCarrots = 0;
        int cutentPos = 0;

        for (int j = 0; j < n; j++)
        {
            int[] jumps = Console.ReadLine().Split
                (new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            eatenCarrots += field[0];
            stepedOn.Add(0);
            int i = -1;

            while (true)
            {
                if (i >= jumps.Length - 1)
                    i = 0;
                else
                    i++;

                cutentPos += jumps[i];

                if (stepedOn.Contains(cutentPos) || cutentPos > field.Length - 1 || cutentPos < 0)
                {
                    break;
                }

                eatenCarrots += field[cutentPos];
                stepedOn.Add(cutentPos);
            }

            maxSetOfCarrots.Add(eatenCarrots);
            stepedOn = new HashSet<int>();
            eatenCarrots = 0;
            cutentPos = 0;
        }

        Console.WriteLine(maxSetOfCarrots.Max());
    }
}
