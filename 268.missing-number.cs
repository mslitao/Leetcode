using System;
using System.Collections.Generic;
using System.Linq;

public class Solution268
{
    public int MissingNumber(int[] nums) {
        var sum =0;
        int max =0;
        foreach(var num in nums)
        {
            sum = sum + num;
            max = Math.Max(max, num);
        }
        
        var res = max * (max+1)/2 -sum;
        return res==0? (max == nums.Length? 0: max+1) :res;
    }
}