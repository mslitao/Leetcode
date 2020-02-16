using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution53 {
    public int MaxSubArray(int[] nums) {
        int maxSum = int.MinValue;
        int sum =0;
        //DP logic, the sum at this position is
        // either nums[i]
        // or nums[i] + sum
        for (int i = 0; i < nums.Length; ++i)
        {
            sum = Math.Max(nums[i], sum+nums[i]);
            maxSum = Math.Max(maxSum, sum);
        }
        return maxSum;
    }

    public int MaxSubArray2(int[] nums) {
        int maxSum = 0;
        int maxVal = int.MinValue;
        int sum =0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] > maxVal)
            {
                maxVal = nums[i];
            }

            if (sum + nums[i] > 0)
            {
                sum = sum + nums[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            else
            {
                sum = 0;
            }
        }
        if (maxSum > 0) return maxSum; 
        else return maxVal;
    }
}