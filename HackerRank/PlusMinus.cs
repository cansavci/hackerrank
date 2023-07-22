using System;

namespace HackerRank
{
    public static class PlusMinus
    {
        public static void solution(int[] arr) {
            int totalCount = arr.Length;
            int plus = 0, minus = 0, zero = 0;
            foreach(int elem in arr){
                if(elem > 0){
                    plus++;
                }
                else if(elem < 0){
                    minus++;
                }
                else{
                    zero++;
                }
            }
            Console.WriteLine((float)plus/totalCount);
            Console.WriteLine((float)minus/totalCount);
            Console.WriteLine((float)zero/totalCount);
        }
    }
}
