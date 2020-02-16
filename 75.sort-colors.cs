using System;
using System.Collections.Generic;
using System.Linq;

public class Solution75 
{
    public void SortColors(int[] nums) 
    {
        int i =0;
        int start = 0;
        int end = nums.Length -1;
        while(i <= end)
        {
            // to make sure all 0 are at begining
            if(nums[i] == 0)
            {
                nums[i] = nums[start];
                nums[start] =0;
                start ++;
                i ++;
            }
            // to make sure all the 2 are at the end.
            else if(nums[i] == 2)
            {
                nums[i] = nums[end];
                nums[end] = 2;
                end --;
            }
            // No need to handle 1, the 1s should be handled by the swap which move them int the middle positions
            // between 0 at the beginning and 2 at the ending.
            else
            {
                i ++;
            }
        }   
    }
}