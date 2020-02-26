using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution704
{
    public int Search(int[] nums, int target) 
    {
        int left = 0;
        int right = nums.Length;
        while(left < right)
        {
            int middle = left + (right - left)/2;
            if(nums[middle] == target) return middle;
            if(nums[middle]< target) left = middle + 1;
            else right = middle;
        }
        
        return -1;
    }

}