using System;
using System.Collections.Generic;

public class Solution27
{
    public int RemoveElement(int[] nums, int val) 
    {
        int slow =0;
        int fast =0;
        while(fast < nums.Length)
        {
            if(nums[fast] != val)
            {
                nums[slow] = nums[fast];
                slow++;
            }
            fast ++;
        }
        return slow;
    }
}