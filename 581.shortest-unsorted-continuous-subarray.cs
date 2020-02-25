using System;
using System.Collections.Generic;
using System.Linq;

public class Solution581
{
    public int FindUnsortedSubarray2(int[] nums) 
    {
        int start = -1;
        int end = -2;
        int max = nums.First();
        int min = nums.Last();
        for(int i =1; i < nums.Length; ++i)
        {
            max = Math.Max(max, nums[i]);
            min = Math.Min(min, nums[nums.Length - i - 1]);

            if(max > nums[i] ) end = i;
            if(min < nums[nums.Length - i - 1]) start = nums.Length - i - 1;
        }

        return end - start +1;
    }
    public int FindUnsortedSubarray(int[] nums) {
            var min = int.MaxValue;
        var max = int.MinValue;

        for(var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                min = Math.Min(min, nums[i + 1]);
            }
        }

        for (var i = nums.Length - 1; i >= 1; i--)
        {
            if (nums[i - 1] > nums[i])
            {
                max = Math.Max(max, nums[i - 1]);
            }
        }

        var head = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            if (min < nums[i])
            {
                head = i;
                break;
            }
        }

        var tail = 0;
        for(var i = nums.Length - 1; i >= 0; i--)
        {
            if (max > nums[i])
            {
                tail = i;
                break;
            }
        }

        return tail > head ? tail - head + 1: 0;
        }
}