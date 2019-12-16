namespace DefaultNamespace
{
    /*
     * Link to challenge
     * https://www.hackerrank.com/challenges/staircase/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     */

public class Staircase
    {
        // Complete the staircase function below.
        static void staircase(int n) {
            int numberOfNs = 1;
            for(int j = 0; j < n; j++){
                for(int i = n; i > 0; i--){
                    if(i > numberOfNs)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                numberOfNs++;
                Console.WriteLine();
            }
        }
    }
}