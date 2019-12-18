namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * shorturl.at/cpO07
     */
    public class CircularArrayRotation
    {
        // Complete the circularArrayRotation function below.
        static int[] circularArrayRotation(int[] a, int k, int[] queries) {

            for(int j = 0; j < k; j++){
                int temp = a[a.Length - 1];
                for(int i = a.Length - 1; i >= 0; i--){
                    if(i == 0){
                        a[i] = temp;
                    }
                    else {
                        a[i] = a[i - 1];
                    }
                }
            }


            int[] result = new int[queries.Length];
            for(int i = 0; i < queries.Length; i++){
                result[i] = a[queries[i]];
            }


            return result;

        }
    }
}