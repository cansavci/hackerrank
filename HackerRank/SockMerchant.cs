using System.Collections.Generic;

namespace HackerRank
{
    class SockMerchant
    {
        int solution(int n, int[] ar)
        {
            var pairsFound = 0;
            var sockColorHash = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (sockColorHash.ContainsKey(ar[i]))
                {
                    pairsFound++;
                    sockColorHash.Remove(ar[i]);
                }
                else
                    sockColorHash.Add(ar[i], 1);
            }
            return pairsFound;
        }
    }
}
