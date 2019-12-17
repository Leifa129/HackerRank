namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * shorturl.at/sO278
     */
    public class ViralAdvertising
    {
        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n) {
            int shared = 5;
            int liked = shared / 2;
            int cumulative = liked;
            for(int i = 0; i < n - 1; i++){
                shared = liked  * 3;
                liked = shared / 2;
                cumulative += liked;
            
            
            }
            return cumulative;

        }
    }
}