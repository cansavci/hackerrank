using System;

namespace HackerRank
{
    public static class TimeConversion
    {
        public static string solution(string s) {
            DateTime d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }
    }
}
