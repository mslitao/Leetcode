using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution35
{
    public int SearchInsert(int[] nums, int target) {
        int i = 0;
        for(; i < nums.Length; ++i)
        {
            if(nums[i] >= target)
                break;
        }

        return i;
    }

    public int SearchInsert_V2(int[] nums, int target) {
        return BinarySearchInsert(nums, target, 0, nums.Length - 1);
    }
    
    public int BinarySearchInsert(int[] nums, int target, int start, int end)
    {
        if(start == end) 
        {
            return nums[start] >= target? start: start + 1;
        }

        int middle = start + (end - start) / 2;

        if(nums[middle] >= target )
        {
            return BinarySearchInsert(nums, target, start, middle);
        }
        else
        {
            return BinarySearchInsert(nums, target, middle + 1, end);
        }
    }
}