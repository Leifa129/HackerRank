namespace DefaultNamespace
{
    /*
     * Link to challenge:
     *  https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
     */
    public class BreakingRecords
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores) {
            int minScore = scores[0];
            int maxScore = scores[0];

            int[] minMaxScoreCount = new int[2];

            for(int i = 1; i < scores.Length; i++){
                if(minScore < scores[i]){
                    minMaxScoreCount[0]++;
                    minScore = scores[i];
                }

                if(maxScore > scores[i]){
                    minMaxScoreCount[1]++;
                    maxScore = scores[i];
                }

            }

            return minMaxScoreCount;

        }
    }
}