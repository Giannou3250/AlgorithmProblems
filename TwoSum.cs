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