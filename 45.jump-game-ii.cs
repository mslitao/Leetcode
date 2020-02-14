using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution45
{
    // It's a BFS based solution. 
    // Each level is one jump.
    // Evertime, update the next round to get the maximum jump
    public int Jump(int[] nums) 
    {
        int res = 0, n = nums.Length, i = 0, cur = 0;
        while (cur < n - 1) 
        {
            ++res;
            int pre = cur;
            for (; i <= pre; ++i) {
                cur = Math.Max(cur, i + nums[i]);
            }
            if (pre == cur) return -1; // May not need this
        }
        return res;
    }
}