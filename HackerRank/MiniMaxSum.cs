using System;
using System.Linq;

namespace HackerRank
{
    public static class MiniMaxSum
    {
        public static void solution(int[] arr) {
            long total = 0;
            foreach(var elem in arr){
                total = total + elem;
            }
            long maxTotal = total - arr.Min();
            long minTotal = total - arr.Max();
            
            Console.WriteLine(minTotal+" "+maxTotal);
        }
    }
}
