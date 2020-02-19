using System;

namespace HackerRank
{
    class RepeatedString
    {
        long solution(string s, long n)
        {
            int lengthOfS = s.Length;

            long total = 0;
            foreach (char c in s)
            {
                if (c == 'a') total++;
            }

            long numberForSeperation = n % lengthOfS;
            long times = n / lengthOfS;
            total = total * times;

            string remaining = s.Substring(0, Convert.ToInt32(numberForSeperation));
            foreach (char c in remaining)
            {
                if (c == 'a') total++;
            }

            return total;
        }
    }
}
