namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * https://www.hackerrank.com/challenges/between-two-sets/problem
     */
    public class BetweenTwoSets
    {
        /*
   * Complete the 'getTotalX' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER_ARRAY a
   *  2. INTEGER_ARRAY b
   */

        public static int getTotalX(List<int> a, List<int> b)
        {   
            var min = a.Max();
            var max = b.Min();
            int count = 0;

            for(int i = min; i <= max; i++){
                if(listIsFactorOfValue(i, a) && valueIsFactorOfList(i, b))
                    count++;
            }

            return count;
        }

        static bool valueIsFactorOfList(int value, List<int> list){
            foreach(var n in list)
                if(n % value != 0)
                    return false;

            return true;
        }

        static bool listIsFactorOfValue(int value, List<int> list){
            foreach(var n in list)
                if(value % n != 0)
                    return false;

            return true;
        }
    }
}