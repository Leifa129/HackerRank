namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * https://www.hackerrank.com/challenges/kangaroo/problem
     */
    public class Kangaroo
    {
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2) {

            while(x1 < x2){
                x1 += v1;
                x2 += v2;
                if(x1 == x2)
                    return "YES";
            }

            return "NO";

        }
    }
}