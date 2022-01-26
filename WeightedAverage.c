/*Question:
The code works correctly for the given example, but users have complained that it doesn't work for some of their cases.
The methods must throw ArgumentException for every illegal argument value or combination. Expected arguments are two same-length arrays. Fix the bugs.

For example, SumProduct called with arrays {3, 6} and {4, 2} returns the sum of products 34+62=24
while WeightedMean called with values {3, 6} and weights {4, 2} should return the weighted mean (34+62)/(4+2)=4.

Code Sample:
*/


using System;
using System.Linq;
using System.Collections.Generic;



public class ArrayMath
{
public static long SumProduct(IList<int> a, IList<int> b)
{
int sum = 0;
if (a.Count != b.Count)
{
    throw new ArgumentException("Array sizes are not the same");
}
else
{
for(int i = 0; i < a.Count; i++)
sum = sum + a[i] * b[i];

    return sum;
}
}
public static double WeightedMean(IList<int> values, IList<int> weights)
{

if (values.Count != weights.Count)
{
    throw new ArgumentException("Array sizes are not the same");
}
else
{
    if (weights.Sum() == 0)
    {
         throw new ArgumentException("Cannot divide by zero");
    }
    double f1 = SumProduct(values, weights);
    double f2 = weights.Sum();
    return f1/ f2;
}
}

public static void Main(string[] args)
{
    var a = new int[] { 1, 0};
    var b = new int[] { 2, 0 };

    //Console.WriteLine(SumProduct(a, b));
    Console.WriteLine(WeightedMean(a, b));
}

}
