using System;
using System.Collections.Generic;
using System.Linq;


public class Solution303
{
    public class NumArray 
    {
        List<int> dp = new List<int>();
        public NumArray(int[] nums) {
            dp.Add(0);
            for(int i = 0; i < nums.Length; ++i)
            {
                dp.Add(dp[i] + nums[i]);
            }
        }
            
        public int SumRange(int i, int j) {
            return dp[j+1] - dp[i];
        }
}
}