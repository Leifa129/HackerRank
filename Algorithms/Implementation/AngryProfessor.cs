namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * https://www.hackerrank.com/challenges/angry-professor/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     */
    
    public class AngryProfessor
    {
        // Complete the angryProfessor function below.
        static string angryProfessor(int k, int[] a) {
            int count = 0;
            for(int i = 0; i < a.Length; i++){
                if(a[i] <= 0){
                    count++;
                    if(count >= k){
                        break;
                    }
                }
            }

            if(count < k)
                return "YES";

            else
                return "NO";

        }
    }
}