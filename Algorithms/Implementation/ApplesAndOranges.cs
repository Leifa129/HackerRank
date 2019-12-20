namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * https://www.hackerrank.com/challenges/apple-and-orange/problem?h_r=next-challenge&h_v=zen
     */
    public class ApplesAndOranges
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
            int applesCount = 0;
            int orangesCount = 0;

            for(int i = 0; i < apples.Length; i++){
                applesCount += onTheHouse(s, t, a, apples[i]);
            }

            for(int i = 0; i < oranges.Length; i++){
                orangesCount += onTheHouse(s, t, b, oranges[i]);
            }
            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        
        }

        static int onTheHouse(int s, int t, int a, int target){
            int value = a + target;
            if(value >= s && value <= t){
                return 1;
            }
            return 0;
        }
    }
}