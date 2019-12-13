﻿﻿namespace DefaultNamespace
{
    /*
     * https://www.hackerrank.com/challenges/greedy-florist/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms&h_r=next-challenge&h_v=zen
     */
 public class GreedyFlorist
    {
        
        // Complete the getMinimumCost function below.
        static int getMinimumCost(int k, int[] c) {
            int customers = 0;
            int price = 0;
            int multiplier = 1;
            Array.Sort(c);

            for(int i = c.Length - 1; i >= 0; i--){
                if(customers == k){
                    multiplier++;
                    customers = 0;
                }

                price += c[i] * multiplier;
                customers++;
            }
            
            return price;
        }

        
    }
}