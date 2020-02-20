using System;
using System.Collections.Generic;
using System.Linq;

public class Solution283
{
    public void MoveZeroes(int[] nums) 
    {
        if(nums.Length <1) return;
        var slowIdx = 0;
        var fastIdx =0;
        while(fastIdx < nums.Length)
        {
            if(nums[fastIdx] != 0)
            {
                nums[slowIdx] = nums[fastIdx];
                slowIdx ++;
            }
            fastIdx ++;
        }

        while(slowIdx < nums.Length)
        {
            nums[slowIdx] = 0;
            slowIdx ++;
        }
    }
}