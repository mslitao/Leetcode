using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution55
{
    // iterate the array from left
    // tryint to use a number with maxreach to tell the current max reach position
    // Break the iteration if the reach can not reach to the current point.
    public bool CanJump(int[] nums) 
    {
        int size = nums.Length;
        if(size == 0) return true;
        int reach = 0;
        for(int i = 0; i < size; ++i)
        {
            if(reach < i || reach >= size -1) break;

            reach = Math.Max(reach, i + nums[i]);
        }

        return reach >= size-1;
    }

    // Start from last position and 
    public bool CanJump2(int[] nums) {
        int lastPos = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            if (i + nums[i] >= lastPos) {
                lastPos = i;
            }
        }
        return lastPos == 0;
    }
}