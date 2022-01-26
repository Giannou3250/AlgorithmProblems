/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

Algorithm - The way I went about coding this problem was by using nested for loops to iterate over 
            over N elements N times. This way we can check every possible addition value combination 
            of every element in the array. Make sure that when iterating the loop if i = j do nothing
            else you can add index values. If inicies I and J add up to the target value then we can 
            return those indicies in the array.
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
         int[] arr1 = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i)
                {
                    j++;
                }
                if (nums[i] + nums[j] == target)
                {
                    arr1[0] = i;
                    arr1[1] = j;
                    return arr1;
                }
            }
        }
        arr1[0] = 0;
        arr1[1] = 0;
        return arr1;
    }
}
