using System;
using System.Collections.Generic;

public class Solution26
{
    public int RemoveDuplicates(int[] nums)
    {
        int length = 0;
        int lastnum = 0;
        //foreach (var num in nums)
        for (int i = 0; i < nums.Length; ++i)
        {
            var num = nums[i];
            if (length == 0)
            {
                lastnum = num;
                length++;
            }
            else
            {
                if (num != lastnum)
                {
                    lastnum = num;
                    length++;

                    nums[length - 1] = num;
                }
            }
        }
        return length;
    }

    public int RemoveDuplicates2(int[] nums)
    {
        int length = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if(i>0 || nums[i] != nums[i-1])
            {
                nums[length ++] = nums[i];
            }
        }
        return length;
    }
}