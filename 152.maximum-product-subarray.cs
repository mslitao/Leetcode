using System;
using System.Collections.Generic;
using System.Linq;

public class Solution152
{
    public int MaxProduct(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;

        int max = nums[0];
        int min = nums[0];
        
        int maxP = nums[0];

        for(int i = 1; i < nums.Length; ++i)
        {
            var temp = max;
            
            max = Math.Max(nums[i], 
                                      Math.Max(max* nums[i], min * nums[i]));

            min = Math.Min(nums[i], 
                                      Math.Min(temp * nums[i], min * nums[i]));

            maxP = Math.Max(maxP, Math.Max(max, min));
        }

        return maxP;
    }
}