﻿namespace DefaultNamespace
{
   /*
    * Link to challenge
    * https://www.hackerrank.com/challenges/plus-minus/problem
    */

public class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr) {
            double negatives = 0;
            double positives = 0;
            double zeros = 0;

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] > 0)
                    positives++;

                else if(arr[i] < 0)
                    negatives++;

                else zeros++;
            }


            Console.WriteLine(positives / arr.Length);
            Console.WriteLine(negatives / arr.Length);
            Console.WriteLine(zeros / arr.Length);


        }
    }
}