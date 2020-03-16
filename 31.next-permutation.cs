using System;
using System.Collections.Generic;

public class Solution31
{
    public void NextPermutation(int[] nums) {
        if(nums == null || nums.Length ==0) return;

        int pos = nums.Length -1;
        while(pos - 1>=0 && nums[pos -1] >= nums[pos])
        {
            pos --;
        }
        
        if(pos >= 1)
        {
            int targetPos = nums.Length -1;
            while(targetPos >= pos && nums[targetPos] <= nums[pos - 1])
            {
                targetPos --;
            }

            int tmp = nums[pos-1];
            nums[pos-1] =  nums[targetPos];
            nums[targetPos] = tmp;
        }

        int left = pos;
        int right = nums.Length -1;
        while(left < right)
        {
            int tmp = nums[left];
            nums[left] =  nums[right];
            nums[right] = tmp;
            left ++; right --;
        }

    }
}