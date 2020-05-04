using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1437
{
    public bool KLengthApart(int[] nums, int k) {
        int lastIdx = -1;
        for(int i =0; i < nums.Length; ++i)
        {
            if(nums[i] == 0) continue;

            if(i == 0) 
            {
                lastIdx = 0;
                continue;
            }

            if(i - lastIdx - 1 < k)
            {
                return false;
            }

            lastIdx = i;
        }

        return true;
    }
}