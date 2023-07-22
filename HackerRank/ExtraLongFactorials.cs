using System;
using System.Numerics;

namespace HackerRank
{
    public static class ExtraLongFactorials
    {
        public static void solution(int n)
        {
            var bi = new BigInteger(1);
            for (var i = 1; i <= n; i++)
            {
                bi *= i;
            }
            Console.Write(bi.ToString());
        }
    }
}
