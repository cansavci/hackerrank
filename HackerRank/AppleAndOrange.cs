using System;

namespace HackerRank
{
    public static class AppleAndOrange
    {
        public static void solution(int s, int t, int a, int b, int[] apples, int[] oranges) {
            var appleHits = 0;
            var orangeHits = 0;

            foreach(var elem in apples){
                if(s == a+elem || t == a+elem || (s < a+elem && a+elem<t ) ){
                    appleHits++;
                }
            }

            foreach(var elem in oranges){
                if(s == b+elem || t == b+elem || (s < b+elem && b+elem<t ) ){
                    orangeHits++;
                }
            }
            
            Console.WriteLine(appleHits);
            Console.WriteLine(orangeHits);
        }
    
    }
}
