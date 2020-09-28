using System;
using System.Linq;

namespace HackerRank
{
    class MinMaxSum
    {
        void solution(int[] arr)
        {
            long maxValSum = 0;
            long minValSum = 0;
            foreach (var elem in arr)
            {
                if (elem == arr.Min())
                {
                    minValSum = minValSum + elem;
                }
                else if (elem == arr.Max())
                {
                    maxValSum = maxValSum + elem;
                }
                else
                {
                    minValSum = minValSum + elem;
                    maxValSum = maxValSum + elem;
                }
            }
            Console.WriteLine(minValSum + " " + maxValSum);
        }
    }
}
