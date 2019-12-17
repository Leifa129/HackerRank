namespace DefaultNamespace
{
    /*
     * Link to challenge:
     * shorturl.at/qxMP9
     */
    public class BeautifulDays
    {
        static int reverseNumber(int i){
            int rem;
            int reverse = 0;
            while(i!=0)      
            {      
                rem=i%10;        
                reverse=reverse*10+rem;      
                i/=10;      
            }      
            return reverse;
        }
        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k) {
            int count = 0;    
            for(int n = i; n<=j; n++){
                int reverse = reverseNumber(n);
                if( (n - reverse) % k == 0){
                    count++;
                }
            }

            return count;

        }
    }
}