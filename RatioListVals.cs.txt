using System.CodeDom.Compiler;
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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double posVal = 0;
        double negVal = 0;
        double zeroVal = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                posVal++;
            }
            else if (arr[i] < 0)
            {
                negVal++;
            }
            else
            {
                zeroVal++;
            }
    
        }
        Console.WriteLine(Math.Round((posVal / arr.Count), 5));
            Console.WriteLine(Math.Round((negVal / arr.Count), 5));
            Console.WriteLine(Math.Round((zeroVal / arr.Count), 5));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
