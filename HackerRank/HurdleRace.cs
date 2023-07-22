using System.Linq;

namespace HackerRank
{
    public static class HurdleRace
    {
        public static int solution(int k, int[] height) {
        var maxHeightToBeReached = height.Max();
        if(k >= maxHeightToBeReached){
            return 0;
        }
        else {
            return maxHeightToBeReached-k;
        }

    }
    
    }
}
