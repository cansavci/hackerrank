using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class BirthdayCakeCandles
    {
        public static int solution(List<int> candles) {
            var tallestCandle = candles.Max();
            var result = candles.Count(p => p == tallestCandle);
            return result;
    }
}
