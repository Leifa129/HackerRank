﻿namespace DefaultNamespace
{
    /*
     * https://www.hackerrank.com/challenges/mini-max-sum/problem
     */
    public class MiniMaxSum
    {
        // Complete the miniMaxSum function below.
        // Find the maximum and minimum sum using 4 numbers in the array of 5.
        static void miniMaxSum(int[] arr) {
            long maxSum = 0;
            long minSum = 0;
            List<int> highest = new List<int>(arr);
            List<int> lowest = new List<int>(arr);
            // Amount of numbers we need to select
            int n = 4;

            highest.Sort();
            highest.Reverse();

            lowest.Sort();

            for(int i = 0; i < n; i++){
                maxSum += highest[i];
                minSum += lowest[i];
            }
            Console.Write(minSum + " " + maxSum);
                

        }
    }
}