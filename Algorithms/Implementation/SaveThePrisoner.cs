namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * shorturl.at/etAHI
     */
    public class SaveThePrisoner
    {
        // Complete the saveThePrisoner function below.
        static int saveThePrisoner(int n, int m, int s) {
            int initialIteration = (m % n);

            if((initialIteration + s - 1) % n == 0)
                return n;
            else
                return (initialIteration + s - 1) % n ;
        }
    }
}