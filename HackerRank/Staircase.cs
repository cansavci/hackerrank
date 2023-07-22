using System;

namespace HackerRank
{
    public static class Staircase
    {
        public static void solution(int n) {
            char hashTag = '#';
            for(int i = 1; i<n+1 ; i++){
                string result = "";
                for(int j = 0; j<i; j++){
                    result = result + hashTag;
                }
                Console.WriteLine(result.PadLeft(n,' '));
            }
        }
    }
}
