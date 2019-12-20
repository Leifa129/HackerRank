namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * shorturl.at/cpO07
     * 
     */
    public class CircularArrayRotation
    {
        // Complete the circularArrayRotation function below.
        static int[] circularArrayRotation(int[] a, int k, int[] queries) {
            int[] temp = new int[a.Length];
            k = k % a.Length;
      
            int j = 0;
            for(int i = a.Length - k; i < a.Length; i++){
                temp[j++] = a[i];
            }
            for (int i = 0; i < a.Length - k; i++) {
                temp[j++] = a[i];
            }

            a = temp;
    


            int[] result = new int[queries.Length];
            for(int i = 0; i < queries.Length; i++){
                result[i] = a[queries[i]];
            }


            return result;

        }
    }
}