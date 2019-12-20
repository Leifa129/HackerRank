﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace DefaultNamespace
{
    /*
     * https://www.hackerrank.com/challenges/diagonal-difference/problem
     */

public class DiagonalDifference
    {
        
        /*
    * Complete the 'diagonalDifference' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts 2D_INTEGER_ARRAY arr as parameter.
    */

        public static int diagonalDifference(List<List<int>> arr)
        {

            int rightSum = 0;
            int leftSum = 0;
            int k = arr.Count - 1;

            for(int i = 0; i < arr.Count; i++){
                for(int j = 0; j < arr[i].Count; j++){
                    if(i == j)
                        leftSum += arr[i][j];
                }

                rightSum += arr[i][k--];

            }

            return Math.Abs(leftSum - rightSum);


        }
                

            
    

    }
    }
}