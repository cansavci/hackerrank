using System.Collections.Generic;

namespace HackerRank
{
    public static class CompareTheTriplets
    {

        public static List<int> solution(List<int> a, List<int> b) {
            int aWins = 0;
            int bWins = 0;
            for(int i = 0; i < a.Count; i++){
                if(a[i] > b[i]){
                    aWins++;
                }
                else if(a[i] < b[i]){
                    bWins++;
                }
            }
            return new List<int>() {aWins, bWins} ;
        }

    }
}
