using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class CountingValleys
    {
        int solution(int n, string s)
        {
            int level = 0;
            int valley = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D') { level--; }
                else { level++; }

                if (s[i] == 'U' && level == 0)
                {
                    valley++;
                }
            }
            return valley;
        }
    }
}
