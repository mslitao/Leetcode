using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1464
{
    public int MaxProduct(int[] nums) {
        int max = int.MinValue;

        for(int i = 0; i < nums.Length; ++i)
        {
            nums[i] = nums[i] -1;
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            for(int j = i + 1; j < nums.Length; ++j)
            {
                int tmp =nums[i] * nums[j];
                max = Math.Max(max, tmp);
            }
        }

        return max;
    }
}