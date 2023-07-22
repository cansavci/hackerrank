namespace HackerRank
{
    public static class BreakingTheRecords
    {
        public static int[] solution(int[] scores) {
            int worstScore = scores[0];
            int worstRecordAchieved = 0;
            int bestScore = scores[0];
            int bestRecordAchieved = 0;
            for(int i=1; i < scores.Length; i++){
                if(scores[i] < worstScore){
                    worstScore = scores[i];
                    worstRecordAchieved++;
                }
                
                if(scores[i] > bestScore){
                    bestScore = scores[i];
                    bestRecordAchieved++;
                }
            }
            int[] result = { bestRecordAchieved, worstRecordAchieved };
            return result;
        }
}
