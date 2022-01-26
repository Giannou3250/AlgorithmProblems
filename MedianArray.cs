/*
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
*/
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int[] z = nums1.Concat(nums2).ToArray();
        Array.Sort(z);
        int middle = (z.Length-1)/2;
        if (z.Length % 2 == 0)
        {
            
            double ans = ((z[middle] + z[middle+1]) / 2.0);
            return ans;
        }
        else
        {
             return z[middle];
        }
    }
}
