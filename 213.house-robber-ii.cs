using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution213
{
    public int Rob(int[] nums) {
        if(nums == null || nums.Length ==0) return 0;
        int cnt = nums.Length;

        if(cnt == 1) return nums[0];

        return Math.Max(Rob(nums, 0, cnt -2), Rob(nums, 1, cnt -1));
    }

    public int Rob(int[] nums, int start, int end)
    {
        if(start == end ) return nums[start];
        int cnt = nums.Length;

        int[] dp1 = new int[cnt + 1]; // Rob the house
        int[] dp2 = new int[cnt + 1]; // Skip the house

        dp1[start] = dp2[end] = 0;

        for(int i = start; i <= end; ++i)
        {
            dp1[i + 1] = dp2[i] + nums[i];
            dp2[i + 1] = Math.Max(dp1[i], dp2[i]);
        }

        return Math.Max(dp1[end + 1], dp2[end + 1]);
    }
}

